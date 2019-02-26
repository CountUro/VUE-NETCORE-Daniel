<template>
  <q-layout>

    <!-- -----------------------            TABLA                ------------------------------ -->

    <q-layout-header>
      <q-table
      title="Lista de Grupo de Compañias"
      :data = listaGrupoCia
      :columns= columnas
      row-key = "nombre"
      :filter = "filtro"
      >

        <!------------ filtro ------------>
        <template slot="top-left" slot-scope="props">
          <q-search hide-underline v-model="filtro"/>
        </template>

        <!------------ Editar ------------>
        <q-td slot="body-cell-editar" slot-scope="props" :props="props">
          <q-icon name="edit" @click.native="VentanaEditar(props.row)"/>
        </q-td>-->

        <!------------ Borrar ------------>
        <q-td slot="body-cell-eliminar" slot-scope="props" :props="props">
          <q-icon name="delete" @click.native="VentanaBorrar(props.row)"/>
        </q-td>-->

        <div slot="top" slot-scope="props" class="row flex-left full-width gutter-x-sm gutter-y-lg">
          <div class="col-xs-12 col-md-1">

            <!------------ Refrescar ------------>
            <q-btn size="md" icon="refresh" :color="colorBotones" class="q-mr-md" @click="GetRegistros">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>

          </div>

          <!------------ Busqueda ------------>
          <div>
            <q-field :count="150" icon="search" :icon-color="colorBotones">
              <q-input :dark="oscuridad" v-model="filtro"/>
            </q-field>
          </div>

          <!------------ Nuevo ------------>
          <div class="col-xs-12 col-md-1">
            <q-btn size="md" icon="add" :color="colorBotones" @click="VentanaAgregar">
              <q-tooltip>Agregar Grupo de Compañias</q-tooltip>
            </q-btn>
          </div>

        </div>

      </q-table>
    </q-layout-header>

    <!-- -----------------------                FINAL - LA TABLA - FINAL                        ------------------------------ -->

    <!-- -----------------------            VENTANA AGREGAR & EDITAR                ------------------------------ -->

    <!-- Propiedates -->
    <q-modal
      v-model="modalAgregaEdita"
      no-backdrop-dismiss
      no-esc-dismiss
      :content-css="{ maxWidth: '25vw', minHeight: '20vh', minWidth: '40vw', maxHeight: '30vh'}"
    >
      <q-modal-layout>

        <!-- Titulo -->
        <q-toolbar slot="header" :color="colorFondoDos">
          <q-toolbar-title>
            {{TituloModal}}
          </q-toolbar-title>
        </q-toolbar>

        <div class="layout-padding">

          <div class="row gutter-x-sm gutter-y-lg">

            <!-- ID -->
            <div class="col-xs-6">
              <q-field :count="100">
                <q-input
                  :dark="oscuridad"
                  ref="grupoCias_id"
                  float-label="ID"
                  v-model="formGrupoCia.grupoCias_id"
                  readonly
                  disabled
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- Nombre -->
            <div class="col-xs-6">
              <q-field :count="100" :error="$v.formGrupoCia.nombre.$error" :error-label="ErrorNombre">
                <q-input
                  :dark="oscuridad"
                  ref="nombre"
                  required
                  float-label="Nombre"
                  v-model.trim="formGrupoCia.nombre"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

          </div>

        </div>

        <q-toolbar slot="footer" :color="colorFondoDos">
          <q-toolbar-title>
            <div class="row gutter-x-sm gutter-y-lg">
              <div class="col-xs-12 col-md-3">
                <q-btn :disabled="!FormaValida" :color="colorBotones" label="Aceptar" @click="AceptarApretado"/>
              </div>
              <div class="col-xs-12 col-md-3">
                <q-btn :color="colorBotones" label="Cancelar" @click="VentanaCerrar"/>
              </div>
            </div>
          </q-toolbar-title>
        </q-toolbar>

      </q-modal-layout>
    </q-modal>

    <!-- -----------------------      FINAL - VENTANA AGREGAR & EDITAR - FINAL               ------------------------------ -->

    <!-- -----------------------                VENTANA BORRAR                        ------------------------------ -->

    <q-dialog
      v-model="dialogBorrar"
      prevent-close
      ok="Eliminar"
      cancel="Cancelar"
      @ok="DeleteRegistro"
      @cancel="VentanaBorrarCerrar"
    >
      <span slot="title">{{formGrupoCiaBorrar.nombre}}</span>
      <span slot="message">{{formGrupoCiaBorrar.mensaje}}</span>
    </q-dialog>

    <!-- -----------------------       FINAL - VENTANA BORRAR - FINAL                        ------------------------------ -->

  </q-layout>
</template>

    <!-- --------------------------------------------------------------------------------------------------------------------------- -->
    <!-- ------------------------------------------     SCRIPT            ---------------------------------------------------------- -->
    <!-- --------------------------------------------------------------------------------------------------------------------------- -->

<script>
import { DominioDetService } from '../../lib/dominioDetService.js'
import { GrupoCiasService } from '../../lib/administracion/grupoCiasService.js'
import { required, maxLength } from 'vuelidate/lib/validators'
import { MyLibjt } from '../../lib/libjt.js'

export default {
  data () {
    return {
      /////////// Colores ///////////
      colorBotones: 'primary',
      colorLetras: 'light',
      colorFondo: 'dark',
      colorFondoDos: 'faded',
      colorResaltado: 'info',
      oscuridad: 'dark',

      filtro: '',

      /////////// Ventana Agregar Editar ///////////
      modalAgregaEdita: false,
      esNuevoRegistro: true,

      formGrupoCia: {
        grupoCias_id: '',
        nombre: ''
      },

      /////////// Ventana Borrar ///////////
      dialogBorrar: false,
      formGrupoCiaBorrar: {
        id: '',
        nombre: '',
        mensaje: ''
      },

      /////////// Tabla ///////////
      listaGrupoCia: [],

      columnas: [
        {
          name: 'editar',
          label: 'Editar',
          align: 'left'
        },

        {
          name: 'nombre',
          label: 'Nombre',
          required: true,
          align: 'left',
          field: 'nombre',
          sortable: true
        },

        {
          name: 'eliminar',
          label: 'Eliminar',
          align: 'right'
        }
      ]
    }
  },

  ////////////////////////////// VALIDATIONS ////////////////////////////////
  validations: {
    formGrupoCia: {
      nombre: { required, maxLength: maxLength(100) }
    },
  },

  ////////////////////////////// COMPUTED ////////////////////////////////
  computed: {
    TituloModal: function () {
      return this.esNuevoRegistro === true ? 'Nuevo Grupo de Compañias' : 'Editar Grupo de Compañias'
    },

    FormaValida: function () {
      this.$v.formGrupoCia.$touch()
      if (this.$v.formGrupoCia.$error){
        return false
      } else {
        return true
      }
    },

    ErrorNombre () {
      return ''
    }
  },

  ////////////////////////////// WATCH ////////////////////////////////
  watch: {

  },

  ////////////////////////////// LIFE CYCLE ////////////////////////////////
  created () {
    this.GetRegistros()
  },

  ////////////////////////////// METHODS ////////////////////////////////
  methods: {

    // GET

    GetRegistros () {
      this.listaGrupoCia = []
      //console.log('llamando registros')
      GrupoCiasService.getAll()
        .then(Respuesta => {
          this.listaGrupoCia = Respuesta.data
          //console.log('listaGrupoCia', listaGrupoCia)
        })
        .catch(error => {
          alert('Error trayendo los Grupos')
        })
    },

    // Post
    AddRegistro () {
      let modelo = {
        nombre: this.formGrupoCia.nombre
      }
      GrupoCiasService.add(modelo)
        .then(Respuesta => {
          this.VentanaCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error agregando el Grupo de Compañias')
        })
    },

    // Put
    UpdateRegistro () {
      let modelo = {
        grupo_cia_id: this.formGrupoCia.grupoCias_id,
        nombre: this.formGrupoCia.nombre
      }
      GrupoCiasService.update(modelo, this.formGrupoCia.grupoCias_id)
        .then(Respuesta => {
          this.VentanaCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error actualizando el Grupo de Compañias')
        })
    },

    DeleteRegistro () {
      GrupoCiasService.remove(this.formGrupoCiaBorrar.id)
        .then(Respuesta => {
          this.VentanaBorrarCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error borrando el Grupo de Compañias')
        })
    },

    // ---------- VENTANAS -------------

    VentanaAgregar () {
      this.esNuevoRegistro = true
      this.modalAgregaEdita = true
    },

    VentanaEditar (item) {
      this.formGrupoCia.grupoCias_id = item.grupo_cia_id
      this.formGrupoCia.nombre = item.nombre
      this.esNuevoRegistro = false
      this.modalAgregaEdita = true
    },

    VentanaCerrar() {
      this.VentanaLimpiar()
      this.modalAgregaEdita = false
    },

    VentanaLimpiar () {
      this.formGrupoCia.grupoCias_id = ''
      this.formGrupoCia.nombre = ''
      this.esNuevoRegistro = true
    },

    VentanaBorrar (item) {
      this.formGrupoCiaBorrar.id = item.grupo_cia_id
      this.formGrupoCiaBorrar.nombre = item.nombre
      this.formGrupoCiaBorrar.mensaje = 'Desea borrar este grupo de Compañia?'
      this.esNuevoRegistro = false
      this.dialogBorrar = true
    },

    VentanaBorrarCerrar () {
      this.formGrupoCiaBorrar.nombre = ''
      this.formGrupoCiaBorrar.mensaje = ''
      this.esNuevoRegistro = true
      this.dialogBorrar = false
    },

    // --------------- Otros ------------------------

   AceptarApretado() {
     this.$v.formGrupoCia.$touch()
     if (this.$v.formGrupoCia.$error) {
       MyLibjt.msgSnackBar('Data Invalida', 'error')
     } else {
       this.GuardarOEditar()
     }
   },

   GuardarOEditar () {
     if (this.esNuevoRegistro === true) {
       this.AddRegistro()
     }else{
       this.UpdateRegistro()
     }
   }



  }

}
</script>
