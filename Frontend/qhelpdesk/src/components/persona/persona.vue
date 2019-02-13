<template>
  <q-layout>
    <!-- ----------------------------------------------------- -->
    <q-layout-header>
      <q-table
      title="Lista de Personas"
      :data = vListaPersonas
      :columns = vColumnas
      row-key = "nombre1"
      :filter = "vFiltro"
      >

        <template slot="top-left" slot-scope="props">
          <!-- <q-search hide-underline v-model="vFiltro"> -->
        </template>

        <q-td slot="body-cell-opciones" slot-scope="props" :props="props">
          <q-icon name="edit" @click.native="editarRegistro(props.row)"/>
        </q-td>-->

        <div slot="top" slot-scope="props" class="row flex-left full-width gutter-x-sm gutter-y-lg">
          <div class="col-xs-12 col-md-1">

            <q-btn size="md" icon="refresh" color="primary" class="q-mr-md" @click="getPersonas">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>

          </div>

          <div>

            <q-field :count="150" icon="search" icon-color="primary">
              <q-input v-model="vFiltro"/>
            </q-field>

          </div>

          <div class="col-xs-12 col-md-1">

            <q-btn size="md" icon="add" color="primary" @click="vNuevoRegistro">
              <q-tooltip>Agregar Persona</q-tooltip>
            </q-btn>

          </div>

        </div>

      </q-table>
    </q-layout-header>

    <!-- ----------------------------------------------------- -->

  </q-layout>
</template>

<script>
import { PersonaService } from '../../lib/personaService.js'
import { required, maxLength } from 'vuelidate/lib/validators'
import { MyLibjt } from '../../lib/libjt.js'

export default {
  data () {
    return {

      vFiltro: '',

      //----------------

      vVentana: {
        persona_id: '',
        //cedula: '',
        nombreP: ''//,
        //nombre2: '',
        //apellido1: '',
        //apellido2: '',
        //tlf_movil: '',
        //tlf_local: '',
        //email: '',
        //cargo: '',
        //sexo_6_id: '' // ??
      },

      //---------------

      // vVentanaBorrar: {
      //   id: '',
      //   nombre1: '',
      //   apellido1: '',
      //   cedula: '',
      //   email: ''
      // },

      //---------------

      vNuevoRegistro: true,
      vModoAE: false,
      vModoBorrar: false,
      vListaPersonas: [],

      //--------------

      vColumnas: [
        {
          name: 'editar',
          label: 'Editar',
          align: 'left'
        },

        {
          name: 'primerNombre',
          label: 'Primer Nombre',
          required: true,
          align: 'left',
          field: 'nombre1',
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

  validations: {
    vVentana: {
      nombreP: { required, maxLength: maxLength(100) }
    }
  },

  // ------------------------------------------------------------------------------

  computed: {
    tituloVentana: function () {
      return this.vNuevoRegistro === true ? 'Nueva Persona' : 'Editar Persona'
    },

    // ------------------------------

    errorNombre (){
      if (!this.$v.vVentana.nombreP.required) {
        return 'Introduzca el nombre de la Persona'
      }
    },

    // ------------------------------

    validForm: function () {
      this.$v.vVentana.$touch()
      if (this.$v.vVentana.$error){
        return false
      } else {
        return true
      }
    }
  },

  // ---------------------------------------------------------------

  watch: {
   vModoAE (val) {
     val || this.cerrarVentana()
   }
  },

  // ------------------------------------------------------------

  created () {
   this.getPersonas()
  },

  // ----------------------------------------------------------

  methods: {

    getPersonas () {
      this.vListaPersonas = []
      PersonaServicio.getAll()
        .then(repsonse => {
          this.vListaPersonas = response.data
        })
        .catch(error => {
          alert('Error trayendo las Peronas')
        })
    },

    // -----------------------------------------

   guardarApretado() {
     this.$v.vVentana.$touch()
     if (this.$v.vVentana.$error) {
       MyLibjt.msgSnackBar('Data Invalida', 'error')
     } else {
       this.guardarOEditar()
     }
   },

  // -----------------------------------

   guardarOEditar () {
     if (this.vNuevoRegistro === true) {
       this.addRegistro()
     }else{
       this.updateRegistro()
     }
   },

   // ----------------------------------

   ventanaEditar (item) {
     this.vVentana.persona_id = item.persona_id
     this.vVtenana.nombreP = item.primerNombre
     this.vNuevoRegistro = false
     this.vModoAE = true
   },

   // ----------------------------------

   updateRegistro () {
     let modelo = {
       persona_id: this.vVentana.persona_id,
       nombre: this.vVentana.nombreP
     }
     PersonaServicio.update(modelo)
        .then(Response => {
          this.cerrarVentana()
          this.getPersonas()
      })
        .catch(error => {
          alert('Error actualizando la Persona')
        })
   },

   // ----------------------------------

   cerrarVentana() {
     this.limpiarVentana()
     this.vModoAE = false
   },

   limpiarVentana () {
     this.vVentana.persona_id = ''
     this.vVentana.nombre = ''
     this.vNuevoRegistro = true
   }

   // ---------------------------------------

  }
}
</script>

