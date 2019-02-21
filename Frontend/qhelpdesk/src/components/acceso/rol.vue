<template>
  <q-layout text-white>
    <q-dialog
      v-model="dialogBorrar"
      prevent-close
      ok="Eliminar"
      cancel="Cancelar"
      @ok="DeleteRegistro"
      @cancel="VentanaLimpiarBorrar"
    >
      <span slot="title">{{formRolBorrar.nombre}}</span>
      <span slot="message">{{this.formRolBorrar.mensaje}}</span>
    </q-dialog>
    <q-modal
      v-model="modalAgregaEdita"
      no-backdrop-dismiss
      no-esc-dismiss
      :content-css="{minWidth: '45vw', minHeight: '40vh '}"
    >
      <q-modal-layout>
        <q-toolbar slot="header">
          <q-toolbar-title>{{ formTitle }}</q-toolbar-title>
        </q-toolbar>
        <div class="layout-padding">
          <div class="row gutter-x-sm gutter-y-lg">
            <div class="col-xs-12">
              <q-field>
                <q-input
                  ref="rol_id"
                  float-label="Id"
                  v-model="formRol.rol_id"
                  readonly
                  disabled
                />
              </q-field>
            </div>
            <div class="col-xs-12">
              <q-field :count="15" :error="$v.formRol.nombre.$error" :error-label="errorNombre">
                <q-input
                  required
                  ref="nombre_columna"
                  float-label="Nombre (*)"
                  v-model.trim="formRol.nombre"
                  @blur="$v.formRol.nombre.$touch"
                />
              </q-field>
            </div>
          </div>
        </div>
          <q-toolbar slot="footer">
          <q-toolbar-title>
            <div class="row gutter-x-sm gutter-y-lg">
              <div class="col-xs-12 col-md-3">
                <q-btn :disabled="!validForm" color="primary" label="Aceptar" @click="AceptarApretado"/>
              </div>
              <div class="col-xs-12 col-md-3">
                <q-btn color="primary" label="Cancelar" @click="VentanaCerrar"/>
              </div>
            </div>
          </q-toolbar-title>
        </q-toolbar>
      </q-modal-layout>
    </q-modal>

    <!-- ---------------------------------------------------------------------------------------------------------------------->

    <q-layout-header>
      <q-table
        title="Lista de roles"
        :data = listaRoles
        :columns = columnasRol
        row-key = "nombre"
        :filter = "filtro"
      >
        <template slot="top-left" slot-scope="props">
          <q-search hide-underline v-model="filtro"/>
        </template>
        <q-td slot="body-cell-opciones" slot-scope="props" :props="props">
          <q-icon name="edit" @click.native="ventanaEditar(props.row)"/>
          <q-icon name="delete" @click.native="ventanaBorrar(props.row)"/>
        </q-td>-->
        <!-- class='row flex-left fit' -->
        <div slot="top" slot-scope="props" class="row flex-left full-width gutter-x-sm gutter-y-lg">
          <div class="col-xs-12 col-md-1">
            <q-btn size="md" icon="refresh" color="primary" class="q-mr-md" @click="GetRoles">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>
          </div>
          <div class="col-xs-12 col-md-4">
            <q-field :count="150" icon="search" icon-color="primary">
              <q-input v-model="filtro"/>
            </q-field>
          </div>
          <div class="col-xs-12 col-md-1">
            <q-btn size="md" icon="add" color="primary" @click="ventanaAgregar">
              <q-tooltip>Agregar Rol</q-tooltip>
            </q-btn>
          </div>
        </div>
      </q-table>
    </q-layout-header>
  </q-layout>
</template>

 <script>
import { RolService } from '../../lib/acceso/rolService.js' // servicio donde existen las funciones
import { required, maxLength } from 'vuelidate/lib/validators' // libreria de vuelidate

export default {
  data () {
    return {
      filtro: '', // filtro a la hora de buscar
      formRol: { // ventana de agregar o editar
        rol_id: '',
        nombre: ''
      },
      esNuevoRegistro: true, // modo add
      modalAgregaEdita: false, // modo agregar o cerrar
      dialogBorrar: false, // activar si la ventana a abrir es para borrar
      listaRoles: [], // datos de roles a organizar en tabla, esto viene de la DB
      formRolBorrar: { // ventana para borrar, diferente de la original ya que incluye mensaje de advertencia
        id: '',
        nombre: '',
        mensaje: ''
      },
      columnasRol: [ // tabla de datos
        {
          name: 'opciones', // nombre variable/slot
          label: 'Opciones', // Usuario ve
          align: 'left' //  alineacion
        },
        {
          name: 'nombre',
          label: 'Nombre',
          required: true, // requerido
          align: 'left',
          field: 'nombre', // campo del objeto mandado
          sortable: true // ordenable
        },
      ]
    }
  },

  validations: { // vuelidate
    formRol: {
      nombre: { required, maxLength: maxLength(100) }
    }
  },

  computed: { // datos computadores
    formTitle: function () { // POR QUE UNOS LLEVAN FUNCTION Y OTROS NO?
      return this.esNuevoRegistro === true ? 'Nuevo Rol' : 'Editar Rol' // titulo a escribir, dependiendo si es add o edit
    },
    errorNombre () { // esto colocara una alerta roja mientras este el campo vacio
       if (!this.$v.formRol.nombre.required) {
        return 'Introduzca el nombre del rol'
      }
      if (!this.$v.formRol.nombre.maxLength) { // esto colocara una alerta roja mientras el campo se exceda
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },
      validForm: function () { // esto bloqueara el boton de commit
      this.$v.formRol.$touch()
      if (this.$v.formRol.$error) { // se bloquea en un error
        return false
      } else {
        return true
      }
    }
  },

  watch: {
    modalAgregaEdita (val) { // ante cualquier cambio de la variable en modo, el sigue, si la variable es false, cierra
      val || this.VentanaCerrar() //esta es una funcion definidia mas abajo
    }
  },

  created () { // al crearse llama a la data a mostrar
    this.GetRoles()
  },

  methods: { // funciones
    AceptarApretado () { // guardar data
      this.$v.formRol.$touch()
      if (this.$v.formRol.$error) {
        MyLibjt.msgSnackBar('Data Invalida', 'error')
      } else {
        this.GuardarOEditar()
      }
    },

    GuardarOEditar () {
      if (this.esNuevoRegistro === true) { // la misma ventana se usa para agregar o editar, aqui se diferencia la orden
        this.AddRegistro()
      } else {
        this.UpdateRegistro()
      }
    },

    AddRegistro () {
      let modelo = { // modelo a pasar como objeto al backend
        nombre: this.formRol.nombre
      }
      RolService.add(modelo)
        .then(Response => {
          this.VentanaCerrar() //cierra
          this.GetRoles() //luego trae nuevamente los roles, para mostrar el agregado tambien
        })
        .catch(error => {
          alert('error agregando rol')
        })
    },

    UpdateRegistro () {
      let modelo = {
        rol_id: this.formRol.rol_id, //igual al modelo en el controller
        nombre: this.formRol.nombre
      }
      RolService.update(modelo)
        .then(Response => {
          this.VentanaCerrar()
          this.GetRoles()
        })
        .catch(error => {
          alert('error actualizando rol')
        })
    },

    ventanaEditar (item) { // el item es el parametro
      this.formRol.rol_id = item.rol_id
      this.formRol.nombre = item.nombre // esto lo pasa la linea de la tabla al que se le dio click
      this.esNuevoRegistro = false
      this.modalAgregaEdita = true //esta en modo edicion o agregar
    },

    ventanaAgregar () {
      this.formRol.rol_id = '' //esta vacio para que el usuario lo agrege
      this.formRol.nombre = ''
      this.esNuevoRegistro = true //es un nuevo registro
      this.modalAgregaEdita = true // esta en modo agregar o editar
    },

    ventanaBorrar (item) { //como en editar, se pasa la data de la fila
      this.formRolBorrar.id = item.rol_id
      this.formRolBorrar.nombre = item.nombre
      this.formRolBorrar.mensaje = 'Desea borrar este rol?' //advertencia
      this.dialogBorrar = true
    },

    DeleteRegistro () {
      RolService.remove(this.formRolBorrar.id)
        .then(response => {
          this.VentanaLimpiarBorrar()
          this.GetRoles() //para mostrar que ya no existe
        })
        .catch(error => {
          alert('error borrando el rol')
        })
    },

    GetRoles () {
      this.listaRoles = [] //esto estara vacio por ahora, reiniciado a 0
      RolService.getAll()
        .then(response => {
          this.listaRoles = response.data //la lista se llenara con la lista de backend
        })
        .catch(error => {
          alert('error trayendo los roles')
        })
    },

    VentanaCerrar () { // funcion (pesronalizada?) que:
      this.VentanaLimpiar() // pone todo en vacio
      this.modalAgregaEdita = false // no esta ni agregando ni editando, estoy cerrando
    },

    VentanaLimpiar () {
      this.formRol.rol_id = ''
      this.formRol.nombre = ''
      this.esNuevoRegistro = true // por que? (para agregar?)
    },

    VentanaLimpiarBorrar () {
      this.formRolBorrar.id = ''
      this.formRolBorrar.nombre = ''
      this.dialogBorrar = false // no estoy borrando, asi que me cierro.
    }

  }


}
</script>
