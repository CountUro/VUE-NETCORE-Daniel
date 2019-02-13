<template>
  <q-layout>
    <q-dialog
      v-model="vModoBorrar"
      prevent-close
      ok="Eliminar"
      cancel="Cancelar"
      @ok="deleteRegistro"
      @cancel="limpiarVentanaBorrar"
    >
      <span slot="title">{{vVentanaBorrar.nombre}}</span>
      <span slot="message">{{this.vVentanaBorrar.mensaje}}</span>
    </q-dialog>
    <q-modal
      v-model="vModoAE"
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
                  v-model="vVentana.rol_id"
                  readonly
                  disabled
                />
              </q-field>
            </div>
            <div class="col-xs-12">
              <q-field :count="15" :error="$v.vVentana.nombre.$error" :error-label="errorNombre">
                <q-input
                  required
                  ref="nombre"
                  float-label="Nombre (*)"
                  v-model.trim="vVentana.nombre"
                  @blur="$v.vVentana.nombre.$touch"
                />
              </q-field>
            </div>
          </div>
        </div>
          <q-toolbar slot="footer">
          <q-toolbar-title>
            <div class="row gutter-x-sm gutter-y-lg">
              <div class="col-xs-12 col-md-3">
                <q-btn :disabled="!validForm" color="primary" label="Aceptar" @click="guardarApretado"/>
              </div>
              <div class="col-xs-12 col-md-3">
                <q-btn color="primary" label="Cancelar" @click="cerrarVentana"/>
              </div>
            </div>
          </q-toolbar-title>
        </q-toolbar>
      </q-modal-layout>
    </q-modal>
    <q-layout-header>
      <q-table
        title="Lista de roles"
        :data = vListaRoles
        :columns = vColumnas
        row-key = "nombre"
        :filter = "vFiltro"
      >
        <template slot="top-left" slot-scope="props">
          <q-search hide-underline v-model="vFiltro"/>
        </template>
        <q-td slot="body-cell-opciones" slot-scope="props" :props="props">
          <q-icon name="edit" @click.native="ventanaEditar(props.row)"/>
          <q-icon name="delete" @click.native="ventanaBorrar(props.row)"/>
        </q-td>-->
        <!-- class='row flex-left fit' -->
        <div slot="top" slot-scope="props" class="row flex-left full-width gutter-x-sm gutter-y-lg">
          <div class="col-xs-12 col-md-1">
            <q-btn size="md" icon="refresh" color="primary" class="q-mr-md" @click="getRoles">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>
          </div>
          <div class="col-xs-12 col-md-4">
            <q-field :count="150" icon="search" icon-color="primary">
              <q-input v-model="vFiltro"/>
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
import { RolService } from '../../lib/rolService.js' // servicio donde existen las funciones
import { required, maxLength } from 'vuelidate/lib/validators' // libreria de vuelidate

export default {
  data () {
    return {
      vFiltro: '', // filtro a la hora de buscar
      vVentana: { // ventana de agregar o editar
        rol_id: '',
        nombre: ''
      },
      vNuevoRegistro: true, // modo add
      vModoAE: false, // modo agregar o cerrar
      vModoBorrar: false, // activar si la ventana a abrir es para borrar
      vListaRoles: [], // datos de roles a organizar en tabla, esto viene de la DB
      vVentanaBorrar: { // ventana para borrar, diferente de la original ya que incluye mensaje de advertencia
        id: '',
        nombre: '',
        mensaje: ''
      },
      vColumnas: [ // tabla de datos
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
    vVentana: {
      nombre: { required, maxLength: maxLength(100) }
    }
  },

  computed: { // datos computadores
    formTitle: function () { // POR QUE UNOS LLEVAN FUNCTION Y OTROS NO?
      return this.vNuevoRegistro === true ? 'Nuevo Rol' : 'Editar Rol' // titulo a escribir, dependiendo si es add o edit
    },
    errorNombre () { // esto colocara una alerta roja mientras este el campo vacio
       if (!this.$v.vVentana.nombre.required) {
        return 'Introduzca el nombre del rol'
      }
      if (!this.$v.vVentana.nombre.maxLength) { // esto colocara una alerta roja mientras el campo se exceda
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },
      validForm: function () { // esto bloqueara el boton de commit
      this.$v.vVentana.$touch()
      if (this.$v.vVentana.$error) { // se bloquea en un error
        return false
      } else {
        return true
      }
    }
  },

  watch: {
    vModoAE (val) { // ante cualquier cambio de la variable en modo, el sigue, si la variable es false, cierra
      val || this.cerrarVentana() //esta es una funcion definidia mas abajo
    }
  },

  created () { // al crearse llama a la data a mostrar
    this.getRoles()
  },

  methods: { // funciones
    guardarApretado () { // guardar data
      this.$v.vVentana.$touch()
      if (this.$v.vVentana.$error) {
        MyLibjt.msgSnackBar('Data Invalida', 'error')
      } else {
        this.guardarOEditar()
      }
    },

    guardarOEditar () {
      if (this.vNuevoRegistro === true) { // la misma ventana se usa para agregar o editar, aqui se diferencia la orden
        this.addRegistro()
      } else {
        this.updateRegistro()
      }
    },

    addRegistro () {
      let modelo = { // modelo a pasar como objeto al backend
        nombre: this.vVentana.nombre
      }
      RolService.add(modelo)
        .then(Response => {
          this.cerrarVentana() //cierra
          this.getRoles() //luego trae nuevamente los roles, para mostrar el agregado tambien
        })
        .catch(error => {
          alert('error agregando rol')
        })
    },

    updateRegistro () {
      let modelo = {
        rol_id: this.vVentana.rol_id, //igual al modelo en el controller
        nombre: this.vVentana.nombre
      }
      RolService.update(modelo)
        .then(Response => {
          this.cerrarVentana()
          this.getRoles()
        })
        .catch(error => {
          alert('error actualizando rol')
        })
    },

    ventanaEditar (item) { // el item es el parametro
      this.vVentana.rol_id = item.rol_id
      this.vVentana.nombre = item.nombre // esto lo pasa la linea de la tabla al que se le dio click
      this.vNuevoRegistro = false
      this.vModoAE = true //esta en modo edicion o agregar
    },

    ventanaAgregar () {
      this.vVentana.rol_id = '' //esta vacio para que el usuario lo agrege
      this.vVentana.nombre = ''
      this.vNuevoRegistro = true //es un nuevo registro
      this.vModoAE = true // esta en modo agregar o editar
    },

    ventanaBorrar (item) { //como en editar, se pasa la data de la fila
      this.vVentanaBorrar.id = item.rol_id
      this.vVentanaBorrar.nombre = item.nombre
      this.vVentanaBorrar.mensaje = 'Desea borrar este rol?' //advertencia
      this.vModoBorrar = true
    },

    deleteRegistro () {
      RolService.remove(this.vVentanaBorrar.id)
        .then(response => {
          this.limpiarVentanaBorrar()
          this.getRoles() //para mostrar que ya no existe
        })
        .catch(error => {
          alert('error borrando el rol')
        })
    },

    getRoles () {
      this.vListaRoles = [] //esto estara vacio por ahora, reiniciado a 0
      RolService.getAll()
        .then(response => {
          this.vListaRoles = response.data //la lista se llenara con la lista de backend
        })
        .catch(error => {
          alert('error trayendo los roles')
        })
    },

    cerrarVentana () { // funcion (pesronalizada?) que:
      this.limpiarVentana() // pone todo en vacio
      this.vModoAE = false // no esta ni agregando ni editando, estoy cerrando
    },

    limpiarVentana () {
      this.vVentana.rol_id = ''
      this.vVentana.nombre = ''
      this.vNuevoRegistro = true // por que? (para agregar?)
    },

    limpiarVentanaBorrar () {
      this.vVentanaBorrar.id = ''
      this.vVentanaBorrar.nombre = ''
      this.vModoBorrar = false // no estoy borrando, asi que me cierro.
    }

  }


}
</script>
