<template>
  <q-layout>

    <!-- -----------------------            VENTANA AGREGAR & EDITAR                ------------------------------ -->

    <!-- Propiedates -->
    <q-modal
      v-model="modalAgregaEdita"
      no-backdrop-dismiss
      no-esc-dismiss
      :content-css="{maxWidth: '45vw', minHeight: '40vh '}"
    >

      <q-modal-layout>

        <!-- Titulo -->
        <q-toolbar slot="header">
          <q-toolbar-title>
            {{TituloModal}}
          </q-toolbar-title>
        </q-toolbar>

        <div class="layout-padding">

          <div class="row gutter-x-sm gutter-y-lg">

            <!-- ID -->
            <div class="col-xs-12 col-md-3">
              <q-field>
                <q-input
                  ref="persona_id"
                  float-label="ID"
                  v-model="formPersona.persona_id"
                  readonly
                  disabled
                />
              </q-field>
            </div>

            <!-- Correo -->
            <div class="col-xs-12 col-md-9">
              <q-field :count="150" :error="$v.formPersona.email.$error" :error-label="ErrorCorreo">
              <!-- <q-field :count="15" > -->
                <q-input
                  required
                  ref="email"
                  float-label="E-Mail"
                  v-model.trim="formPersona.email"
                />
              </q-field>
            </div>
          </div>

          <div class="row gutter-x-sm gutter-y-lg">

            <!-- Cedula -->
            <div class="col-xs-12 col-md-4">
              <q-field :count="15" :error="$v.formPersona.cedula.$error" :error-label="ErrorCedula">
              <!-- <q-field :count="15"> -->
                <q-input
                  required
                  ref="cedula"
                  float-label="Cedula / NIE"
                  v-model.trim="formPersona.cedula"
                />
              </q-field>
            </div>


            <!-- Titulo -->
            <div class="col-xs-12 col-md-8">
              <q-field :count="60" :error="$v.formPersona.cargo.$error" :error-label="ErrorCargo">
              <!-- <q-field :count="15" > -->
                <q-input
                  required
                  ref="cargo"
                  float-label="Titulo"
                  v-model.trim="formPersona.cargo"
                />
              </q-field>
            </div>
          </div>

          <div class="row gutter-x-sm gutter-y-lg">
            <!-- Nombre -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formPersona.nombre1.$error" :error-label="ErrorNombre1">
              <!-- <q-field :count="15"> -->
                <q-input
                  required
                  ref="nombre1"
                  float-label="Primer Nombre (*)"
                  v-model.trim="formPersona.nombre1"
                  @blur="$v.formPersona.nombre1.$touch"
                />
              </q-field>
            </div>

            <!-- Segundo Nombre -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formPersona.nombre2.$error" :error-label="ErrorNombre2">
              <!-- <q-field :count="15" > -->
                <q-input
                  required
                  ref="nombre2"
                  float-label="Segundo Nombre"
                  v-model.trim="formPersona.nombre2"
                />
              </q-field>
            </div>

            <!-- Primer Apellido -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formPersona.apellido1.$error" :error-label="ErrorApellido1">
              <!-- <q-field :count="15" > -->
                <q-input
                  required
                  ref="apellido1"
                  float-label="Primer Apellido (*)"
                  v-model.trim="formPersona.apellido1"
                />
              </q-field>
            </div>

            <!-- Segundo Apellido -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formPersona.apellido2.$error" :error-label="ErrorApellido2">
              <!-- <q-field :count="15" > -->
                <q-input
                  required
                  ref="apellido2"
                  float-label="Segundo Apellido"
                  v-model.trim="formPersona.apellido2"
                />
              </q-field>
            </div>
            </div>
            <div class="row gutter-x-sm gutter-y-lg">
            <!-- Telefono Movil -->
            <div class="col-xs-12 col-md-4">
              <q-field :count="20" :error="$v.formPersona.tlf_movil.$error" :error-label="ErrorTlf_movil">
              <!-- <q-field :count="15"> -->
                <q-input
                  required
                  ref="tlf_movil"
                  float-label="N° Movil"
                  v-model.trim="formPersona.tlf_movil"
                />
              </q-field>
            </div>

            <!-- Telefono Fijo -->
            <div class="col-xs-12 col-md-4">
              <q-field :count="20" :error="$v.formPersona.tlf_local.$error" :error-label="ErrorTlf_local">
                <q-input
                  required
                  ref="tlf_local"
                  float-label="N° Telefono Fijo"
                  v-model.trim="formPersona.tlf_local"
                />
              </q-field>

            <!-- Sexo
            <div class="col-xs-12 col-md-4">
              <q-field :count="20" :error="$v.formPersona.sexo_6_id.$error" :error-label="ErrorSexo">

                <q-select
                  v-model="formPersona.sexo_6_id"
                  radio
                  float-label="Sexo"
                  :options="listaSexos"
                  @blur="$v.formPersona.sexo_6_id.$touch"
                />
              </q-field>
            </div> -->

            </div>

          </div>

        </div>
        <q-toolbar slot="footer">
          <q-toolbar-title>
            <div class="row gutter-x-sm gutter-y-lg">
              <div class="col-xs-12 col-md-3">
                <q-btn :disabled="!FormaValida" color="primary" label="Aceptar" @click="AceptarApretado"/>
              </div>
              <div class="col-xs-12 col-md-3">
                <q-btn color="primary" label="Cancelar" @click="VentanaCerrar"/>
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
      <span slot="title">{{formPersonaBorrar.nombre_comp}}</span>
      <span slot="message">{{formPersonaBorrar.mensaje}}</span>
    </q-dialog>

    <!-- -----------------------       FINAL - VENTANA BORRAR - FINAL                        ------------------------------ -->


    <!-- -----------------------                LA TABLA                        ------------------------------ -->

    <q-layout-header>
      <q-table
      title="Lista de Personas"
      :data = listaPersonas
      :columns = Columnas
      row-key = "cedula"
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
            <q-btn size="md" icon="refresh" color="primary" class="q-mr-md" @click="GetRegistros">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>

          </div>

          <!------------ Busqueda ------------>
          <div>
            <q-field :count="150" icon="search" icon-color="primary">
              <q-input v-model="filtro"/>
            </q-field>
          </div>

          <!------------ Nuevo ------------>
          <div class="col-xs-12 col-md-1">
            <q-btn size="md" icon="add" color="primary" @click="VentanaAgregar">
              <q-tooltip>Agregar Persona</q-tooltip>
            </q-btn>
          </div>

        </div>

      </q-table>
    </q-layout-header>

    <!-- -----------------------                FINAL - LA TABLA - FINAL                        ------------------------------ -->

  </q-layout>
</template>

    <!-- --------------------------------------------------------------------------------------------------------------------------- -->
    <!-- ------------------------------------------     SCRIPT            ---------------------------------------------------------- -->
    <!-- --------------------------------------------------------------------------------------------------------------------------- -->

<script>
import { PersonaService } from '../../lib/personaService.js'
import { required, maxLength } from 'vuelidate/lib/validators'
import { MyLibjt } from '../../lib/libjt.js'

export default {
  data () {
    return {

      filtro: '',

      //----------------
      modalAgregaEdita: false,
      esNuevoRegistro: true,

      formPersona: {
        persona_id: '',
        cedula: '',
        nombre1: '',
        nombre2: '',
        apellido1: '',
        apellido2: '',
        tlf_movil: '',
        tlf_local: '',
        email: '',
        cargo: '',
        sexo_6_id: ''
      },


      //---------------
      dialogBorrar: false,

      formPersonaBorrar: {
        id: '',
        nombre_comp: '',
        //apellido1: '',
        //cedula: '',
        //email: '',
        //mensaje: ''
      },

      //---------------
      listaPersonas: [],
      listaSexos: [],

      Columnas: [
        {
          name: 'editar',
          label: 'Editar',
          align: 'left'
        },

        {
          name: 'cedula',
          label: 'Cédula',
          required: true,
          align: 'left',
          field: 'cedula',
          sortable: true
        },

        {
          name: 'nombre1',
          label: 'Primer Nombre',
          required: true,
          align: 'left',
          field: 'nombre1',
          sortable: true
        },

        {
          name: 'nombre2',
          label: 'Segundo Nombre',
          align: 'left',
          field: 'nombre2',
          sortable: true
        },

        {
          name: 'apellido1',
          label: 'Primer Apellido',
          required: true,
          align: 'left',
          field: 'apellido1',
          sotrable: true
        },

        {
          name: 'apellido2',
          label: 'Segundo Apellido',
          align: 'left',
          field: 'apellido2',
          sotrable: true
        },

        {
          name: 'tlf_movil',
          label: 'N° Movil',
          align: 'left',
          field: 'tlf_movil' // mascara?
        },

        {
          name: 'tlf_local',
          label: 'N° Telefono Fijo',
          align: 'left',
          field: 'tlf_local' // mascara?
        },

        {
          name: 'email',
          label: 'E-Mail',
          align: 'left',
          required: true,
          field: 'email' // mascara?
        },

        {
          name: 'cargo',
          label: 'Título',
          align: 'left',
          field: 'cargo',
          sotrable: true
        },

        {
          name: 'sexo6',
          label: 'Sexo',
          align: 'left',
          field: 'sexo6', // Como escribo el sexo?
          sotrable: true
        },

        {
          name: 'eliminar',
          label: 'Eliminar',
          align: 'right'
        }
      ]
        // public int persona_id { get; set; }
        // public string cedula { get; set; }
        // public string nombre1 { get; set; }
        // public string nombre2 { get; set; }
        // public string apellido1 { get; set; }
        // public string apellido2 { get; set; }
        // public string nombre_comp { get; set; }
        // public string tlf_movil { get; set; }
        // public string tlf_local { get; set; }
        // public string email { get; set; }
        // public string cargo { get; set; }
        // public long sexo_6_id { get; set; }
        // public string sexo6 { get; set; }
    }
  },

  validations: {
    formPersona: {
      nombre1: { required, maxLength: maxLength(100) },
      nombre2: { maxLength: maxLength(100) },
      apellido1: { required, maxLength: maxLength(100) },
      apellido2: { maxLength: maxLength(100) },
      email: { required, maxLength: maxLength(50) },
      tlf_movil: { maxLength: maxLength(20) },
      tlf_local: { maxLength: maxLength(20) },
      cedula: { required, maxLength: maxLength(20) },
      cargo: { maxLength: maxLength(20) }
      // sexo?
    }
  },

  // --------------------------- COMPUTED ---------------------------------------------------

  computed: {
    TituloModal: function () {
      return this.esNuevoRegistro === true ? 'Nueva Persona' : 'Editar Persona'
    },

    // -------

    ErrorNombre1 () {
      if (!this.$v.formPersona.nombre1.required) {
        return 'Introduzca el nombre de la Persona'
      }
      if (!this.$v.formPersona.nombre1.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorNombre2 () {
      if (!this.$v.formPersona.nombre2.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorApellido1 () {
      if (!this.$v.formPersona.apellido1.required) {
        return 'Introduzca el Apellido de la Persona'
      }
      if (!this.$v.formPersona.apellido1.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorApellido2 () {
      if (!this.$v.formPersona.apellido2.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorCorreo () {
      if (!this.$v.formPersona.email.required) {
        return 'Introduzca el nombre de la Persona'
      }
      if (!this.$v.formPersona.email.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorTlf_movil () {
      if (!this.$v.formPersona.tlf_movil.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorTlf_local () {
      if (!this.$v.formPersona.tlf_local.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorCargo () {
      if (!this.$v.formPersona.cargo.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorCedula () {
      if (!this.$v.formPersona.cedula.required) {
        return 'Introduzca el nombre de la Persona'
      }
      if (!this.$v.formPersona.cedula.maxLength) {
        return 'No puede exceder de 100 caracteres'
      }
      return ''
    },

    ErrorSexo () {
      return ''
    },

    // --------

    FormaValida: function () {
      this.$v.formPersona.$touch()
      if (this.$v.formPersona.$error){
        return false
      } else {
        return true
      }
    }
  },

  // ------------------------ WATCH ---------------------------------------

  watch: {
   modalAgregaEdita (val) {
     val || this.VentanaCerrar()
   }
  },

  // --------------------- LYFE CYCLE -------------------------------------

  created () {
   this.GetRegistros()
  },

  // ---------------------- METODOS ------------------------------------

  methods: {

  // GET ---

    GetRegistros () {
      console.log('estoy llamando joeputaxxxxxx')
      this.listaPersonas = []
      PersonaService.getAll()
        .then(Respuesta => {
          this.listaPersonas = Respuesta.data
        })
        .catch(error => {
          console.log('error', error.data)
          alert('Error trayendo las Personas')
        })
        //console.log(self.listaPersonas)
    },

    GetSexos() {
      let self = this
      self.listaSexos = []
      DominioDetService.select(this.pais_id, 6, false, 2)
        .then(respuesta => {
          self.sexos= respuesta.data
        })
        .catch(error => {
          alert('Error trayendo Sexos')
        })
        console.log(self.sexos)
    },

   // PUT ---

   UpdateRegistro () {
     let modelo = {
       persona_id: this.formPersona.persona_id,
       cedula: this.formPersona.cedula,
       nombre1: this.formPersona.nombre1,
       nombre2: this.formPersona.nombre2,
       apellido1: this.formPersona.apellido1,
       apellido2: this.formPersona.apellido2,
       tlf_movil: this.formPersona.tlf_movil,
       tlf_local: this.formPersona.tlf_local,
       email: this.formPersona.email,
       cargo: this.formPersona.cargo,
       sexo_6_id: parseInt(this.formPersona.sexo_6_id)
     }
     console.log('modelo', modelo)
     PersonaService.update(modelo)
        .then(Response => {
          this.VentanaCerrar()
          this.GetRegistros()
      })
        .catch(error => {
          alert('Error actualizando la Persona')
        })
   },

   // POST ---

   AddRegistro () {
     let modelo = {
       nombre1: this.formPersona.nombre1
     }
     PersonaService.add(modelo)
        .then(Response => {
          this.VentanaCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error agregando la persona')
        })
   },

   // DELETE ---

   DeleteRegistro () {
     PersonaService.remove(this.formPersonaBorrar.id)
        .then(Response => {
          this.VentanaBorrarCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error borrando el registro')
        })
   },

   // -------------- Ventanas --------------------

   VentanaAgregar () {
     this.formPersona.persona_id = ''
     this.formPersona.nombre1 = ''
     this.esNuevoRegistro = true
     this.modalAgregaEdita = true
   },

   // ---

   VentanaEditar (item) {
     this.formPersona.persona_id = item.persona_id
     this.formPersona.nombre1 = item.nombre1
     this.formPersona.nombre2 = item.nombre2
     this.formPersona.apellido1 = item.apellido1
     this.formPersona.apellido2 = item.apellido2
     this.formPersona.tlf_movil = item.tlf_movil
     this.formPersona.tlf_local = item.tlf_local
     this.formPersona.email = item.email
     this.formPersona.cargo = item.cargo
     this.formPersona.cedula = item.cedula
     this.esNuevoRegistro = false
     this.modalAgregaEdita = true
   },

   // ---

   VentanaBorrar (item) {
     this.dialogBorrar = true
     this.formPersonaBorrar.id = item.persona_id
     this.formPersonaBorrar.nombre_comp = item.nombre_comp
     //this.dialogBorrar.apellido1 = item.apellido1
     //this.dialogBorrar.cedula = item.cedula
     //this.dialogBorrar.email = item.email
     this.formPersonaBorrar.mensaje = 'Desea eliminar esta Persona?'
   },

   VentanaCerrar() {
     this.VentanaLimpiar()
     this.modalAgregaEdita = false
   },

   // ---

   VentanaLimpiar () {
     this.formPersona.persona_id = ''
     this.formPersona.nombre1 = ''
     this.formPersona.nombre2 = ''
     this.formPersona.apellido1 = ''
     this.formPersona.apellido2 = ''
     this.formPersona.tlf_movil = ''
     this.formPersona.tlf_local = ''
     this.formPersona.email = ''
     this.formPersona.cargo = ''
     this.formPersona.cedula = ''
     this.esNuevoRegistro = true
   },

   VentanaBorrarCerrar () {
     this.formPersonaBorrar.nombre_comp = ''
     this.formPersonaBorrar.mensaje = ''
     this.dialogBorrar = false
   },

   // --------------- Otros ------------------------

   AceptarApretado() {
     this.$v.formPersona.$touch()
     if (this.$v.formPersona.$error) {
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
