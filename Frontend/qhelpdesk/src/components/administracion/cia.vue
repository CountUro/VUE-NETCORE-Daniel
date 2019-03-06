<template>
  <q-layout>

    <!-- -----------------------            VENTANA AGREGAR & EDITAR                ------------------------------ -->

    <q-modal
      v-model="modalAgregaEdita"
      no-backdrop-dismiss
      no-esc-dismiss
      :content-css="{ maxWidth: '80vw', minHeight: '70vh', minWidth: '50vw', maxHeight: '100vh'}"
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

            <!-- Nombre -->
            <div class="col-xs-12">
              <q-field :count="100" :error="$v.formCia.nombre.$error" :error-label="ErrorNombre">
                <q-input
                  :dark="oscuridad"
                  ref="nombre"
                  required
                  float-label="Nombre"
                  v-model.trim="formCia.nombre"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

          </div>
          <div class="row gutter-x-sm gutter-y-lg">

            <!-- ID -->
            <div class="col-xs-3">
              <q-field>
                <q-input
                  :dark="oscuridad"
                  ref="cia_id"
                  float-label="ID"
                  v-model="formCia.cia_id"
                  readonly
                  disabled
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- rif -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formCia.rif.$error" :error-label="ErrorRif">
                <q-input
                  :dark="oscuridad"
                  ref="rif"
                  required
                  float-label="RIF"
                  v-model.trim="formCia.rif"
                  :color="colorResaltado"
                />
              </q-field>
            </div>


            <!-- GrupoCias -->
            <div class="col-xs-6">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.grupo_cia_id"
                  radio
                  float-label="Grupo de Compañias"
                  :options="listaGrupoCias"

                />
              </q-field>
            </div>

          </div>

          <div class="row gutter-x-sm gutter-y-lg">

            <!-- Pais -->
            <div class="col-xs-4">
              <q-field :count="1" :error="$v.formCia.pais_id.$error" :error-label="ErrorLocacion">
                <q-select
                  filter
                  :dark="oscuridad"
                  v-model="formCia.pais_id"
                  radio
                  float-label="Pais"
                  :options="listaPaises"
                />
              </q-field>
            </div>

            <!-- Estado -->
            <div class="col-xs-4">
              <q-field :count="1" :error="$v.formCia.estado_id.$error" :error-label="ErrorLocacion">
                <q-select
                  filter
                  :dark="oscuridad"
                  v-model="formCia.estado_id"
                  radio
                  float-label="Estado"
                  :options="listaEstados"
                  :disable="estadoSelector"
                />
              </q-field>
            </div>

            <!-- Ciudad -->
            <div class="col-xs-4">
              <q-field :count="1" :error="$v.formCia.ciudad_id.$error" :error-label="ErrorLocacion">
                <q-select
                  filter
                  :dark="oscuridad"
                  v-model="formCia.ciudad_id"
                  radio
                  float-label="Ciudad"
                  :options="listaCiudades"
                  :disable="ciudadSelector"
                />
              </q-field>
            </div>

          </div>
          <div class="row gutter-x-sm gutter-y-lg">

            <!-- Activa -->
            <div class="col-xs-3">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.activa"
                  radio
                  float-label="Activacion"
                  :options="activoDesactivo"
                  :disable="esNuevoRegistro"
                />
              </q-field>
            </div>

            <!-- Bloqueada -->
            <div class="col-xs-3">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.bloqueada"
                  radio
                  float-label="Permiso"
                  :options="bloqueadaDesbloqueada"
                  :disable="esNuevoRegistro"
                />
              </q-field>
            </div>

            <!-- soporte opciones -->
            <div class="col-xs-3">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.soporte_id"
                  radio
                  float-label="Soporte"
                  :options="listaSoporte"
                />
              </q-field>
            </div>

            <!-- codigo DB -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formCia.codigo_bd.$error" :error-label="ErrorCodigo_bd">
                <q-input
                  :dark="oscuridad"
                  ref="codigo_bd"
                  float-label="Codigo de Database"
                  v-model.trim="formCia.codigo_bd"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

          </div>
          <div class="row gutter-x-sm gutter-y-lg">

            <!-- marca 87 opciones-->
            <div class="col-xs-4">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.marca_87_id"
                  radio
                  float-label="Corporacion"
                  :options="listaMarcas"
                />
              </q-field>
            </div>

            <!-- marca -->
            <div class="col-xs-4">
              <q-field :count="100">
                <q-input
                  :dark="oscuridad"
                  ref="marca"
                  float-label="Marca(s)"
                  v-model.trim="formCia.marca"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- tipo166 opciones -->
            <div class="col-xs-4">
              <q-field :count="1">
                <q-select
                  :dark="oscuridad"
                  v-model="formCia.tipo_166_id"
                  radio
                  float-label="Tipo"
                  :options="listaTipos"
                />
              </q-field>
            </div>

          </div>
          <div class="row gutter-x-sm gutter-y-lg">

            <!-- lic alquiler -->
            <div class="col-xs-3">
              <q-field :count="50" :error="$v.formCia.lic_alquiler.$error" :error-label="ErrorLicencia">
                <q-input
                  :dark="oscuridad"
                  ref="lic_alquiler"
                  float-label="Licencia de Alquiler"
                  v-model.trim="formCia.lic_alquiler"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- lic vta -->
            <div class="col-xs-3">
              <q-field :count="50" :error="$v.formCia.lic_vta.$error" :error-label="ErrorLicencia">
                <q-input
                  :dark="oscuridad"
                  ref="lic_vta"
                  float-label="Licencia de Venta"
                  v-model.trim="formCia.lic_vta"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- version app -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formCia.version_app.$error" :error-label="ErrorIntroduzca">
                <q-input
                  :dark="oscuridad"
                  ref="version_app"
                  float-label="Vr. de la Aplicacion"
                  v-model.trim="formCia.version_app"
                  :color="colorResaltado"
                />
              </q-field>
            </div>

            <!-- version database -->
            <div class="col-xs-3">
              <q-field :count="100" :error="$v.formCia.version_bd.$error" :error-label="ErrorIntroduzca">
                <q-input
                  :dark="oscuridad"
                  ref="version_bd"
                  float-label="Vr. de la Base de Datos"
                  v-model.trim="formCia.version_bd"
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
      <span slot="title">{{formCiaBorrar.nombre}}</span>
      <span slot="message">{{formCiaBorrar.mensaje}}</span>
    </q-dialog>

    <!-- -----------------------       FINAL - VENTANA BORRAR - FINAL                        ------------------------------ -->

    <!-- -----------------------            TABLA                ------------------------------ -->
    <q-layout-header>
      <q-table
      title="Lista de Compañias"
      :data = listaCia
      :columns= columnas
      row-key = "nombre"
      :filter = "filtro"
      :dark = "oscuridad"
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

import { CiaService } from '../../lib/administracion/ciaService.js'
import { required, maxLength } from 'vuelidate/lib/validators'
import { MyLibjt } from '../../lib/libjt.js'
import { DominioDetService } from '../../lib/dominioDetService.js'

import { GrupoCiasService } from '../../lib/administracion/grupoCiasService.js'
import { PaisService } from '../../lib/region/paisService.js'
import { EstadoService } from '../../lib/region/estadoService.js'
import { CiudadService } from '../../lib/region/ciudadService.js'
import { SoporteService } from '../../lib/hq/soporteService.js'


      // public string rif { get; set; }
      // public string nombre { get; set; }
      // public int grupo_cia_id { get; set; }
      // public long tipo_166_id { get; set; }
      // public int pais_id { get; set; }
      // public int estado_id { get; set; }
      // public int ciudad_id { get; set; }
      // public long marca_87_id { get; set; }
      // public int soporte_id { get; set; }
      // public string codigo_bd { get; set; }
      // public int lic_alquiler { get; set; }
      // public int lic_vta { get; set; }
      // public string version_app { get; set; }
      // public string version_bd { get; set; }
      // public string marca { get; set; }


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

      listaGrupoCias: [],
      listaPaises: [],

      listaEstados: [],
      estadoSelector: true,

      listaCiudades: [],
      ciudadSelector: true,

      activoDesactivo: [
        {
          label: 'Activa',
          value: 'true'
        },

        {
          label: 'Desactiva',
          value: 'false'
        }
      ],

      bloqueadaDesbloqueada: [
        {
          label: 'Bloqueada',
          value: 'true'
        },

        {
          label: 'Libre',
          value: 'false'
        }
      ],

      listaMarcas: [],
      listaTipos: [],
      listaSoporte: [],

      formCia: {
        rif: '',
        nombre: '',
        grupo_cia_id: '',
        tipo_166_id: '',
        pais_id: '',
        estado_id: '',
        ciudad_id: '',
        marca_87_id: '',
        soporte_id: '',
        codigo_bd: '',
        lic_alquiler: '',
        lic_vta: '',
        version_app: '',
        version_bd: '',
        activa: '',
        bloqueada: '',
        marca: ''
      },

      /////////// Ventana Borrar ///////////
      dialogBorrar: false,
      formCiaBorrar: {
        id: '',
        nombre: '',
        mensaje: ''
      },

      /////////// Tabla ///////////
      listaCia: [],

      columnas: [
        {
          name: 'editar',
          label: 'Editar',
          align: 'left'
        },

        {
          name: 'rif',
          label: 'RIF',
          required: true,
          align: 'left',
          field: 'rif',
          sortable: true
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
          name: 'grupocia',
          label: 'Grupo de Compañia',
          required: true,
          align: 'left',
          field: 'grupocia',
          sortable: true
        },

        {
          name: 'tipos166',
          label: 'Tipo de Empresa',
          required: true,
          align: 'left',
          field: 'tipos166',
          sortable: true
        },

        {
          name: 'marca87',
          label: 'Corporacion',
          required: true,
          align: 'left',
          field: 'marca87',
          sortable: true
        },

        {
          name: 'marca',
          label: 'Marcas en Tienda',
          required: true,
          align: 'left',
          field: 'marca',
          sortable: true
        },

        {
          name: 'soporte',
          label: 'Soporte',
          required: true,
          align: 'left',
          field: 'soporte',
          sortable: true
        },

        {
          name: 'codigo_bd',
          label: 'Codigo de la DB',
          required: true,
          align: 'left',
          field: 'codigo_bd',
          sortable: true
        },

        {
          name: 'version_bd',
          label: 'Version de la DB',
          required: true,
          align: 'left',
          field: 'version_bd',
          sortable: true
        },

        {
          name: 'version_app',
          label: 'Version de la APP',
          required: true,
          align: 'left',
          field: 'version_app',
          sortable: true
        },

        {
          name: 'lic_alquiler',
          label: 'Licencia de Alquiler',
          required: true,
          align: 'left',
          field: 'lic_alquiler',
          sortable: true
        },

        {
          name: 'lic_vta',
          label: 'Licencia de Venta',
          required: true,
          align: 'left',
          field: 'lic_vta',
          sortable: true
        },

        {
          name: 'ciudad',
          label: 'Ciudad',
          required: true,
          align: 'left',
          field: 'ciudad',
          sortable: true
        },

        {
          name: 'estado',
          label: 'Estado',
          required: true,
          align: 'left',
          field: 'estado',
          sortable: true
        },

        {
          name: 'pais',
          label: 'Pais',
          required: true,
          align: 'left',
          field: 'pais',
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
    formCia: {
      nombre: { required, maxLength: maxLength(100) },
      rif: { required, maxLength: maxLength(50) },
      grupo_cia_id: { required },
      codigo_bd: { maxLength: maxLength(50) },
      pais_id: { required },
      estado_id: { required },
      ciudad_id: { required },
      lic_alquiler: { maxLength: maxLength(50) },
      lic_vta: { maxLength: maxLength(50) },
      version_app: { required },
      version_bd: { required }
    }
  },

  computed: {
    TituloModal: function () {
      return this.esNuevoRegistro === true ? 'Nueva Compañia' : 'Editar Compañia'
    },

    PaisID: function () {
      return this.formCia.pais_id
    },

    EstadoID: function () {
      return this.formCia.estado_id
    },

    FormaValida: function () {
      this.$v.formCia.$touch()
      if (this.$v.formCia.$error){
        return false
      } else {
        return true
      }
    },

    ErrorNombre () {
      if (!this.$v.formCia.nombre.required) {
        return 'Introduzca el Nombre.'
      }

      return ''
    },

    ErrorRif () {
      if (!this.$v.formCia.rif.required) {
        return 'Introduzca el RIF.'
      }

      return ''
    },

    ErrorCodigo_bd () {
      return ''
    },

    ErrorLicencia () {
      if (!this.$v.formCia.lic_alquiler.required || !this.$v.formCia.lic_vta.required) {
        return 'Introduzca la licencia.'
      }

      return ''
    },

    ErrorLocacion () {
      if (!this.$v.formCia.pais_id.required || !this.$v.formCia.estado_id.required || !this.$v.formCia.ciudad_id.required) {
        return 'Introduzca la locacion.'
      }

      return ''
    },

    ErrorIntroduzca () {
      if (!this.$v.formCia.version_app.required || !this.$v.formCia.version_bd.required) {
        return 'Introduzca la informacion.'
      }

      return ''
    }
  },

  watch: {
    PaisID (val) {
      if (val === undefined || val === '' || val === null) {
        this.estadoSelector = true
        this.formCia.estado_id = ''
        this.listaEstados = []
      } else {
        this.estadoSelector = false
        this.GetEstados(val)
      }
    },

    EstadoID (val) {
      if (val === undefined || val === '' || val === null) {
        this.ciudadSelector = true
        this.formCia.ciudad_id = ''
        this.listaCiudades = []
      } else {
        this.ciudadSelector = false
        this.GetCiudades(val)
      }
    },

  },

  ////////////////////////////// LIFE CYCLE ////////////////////////////////
  created () {
    this.GetRegistros()
    this.GetGrupoCias()
    this.GetPaises()
    this.GetMarcas()
    this.GetTipos()
    this.GetSoportes()
  },

  ////////////////////////////// METHODS ////////////////////////////////
  methods: {

    // GET
    GetRegistros () {
      this.listaCia = []
      //console.log('llamando registros')
      CiaService.getAll()
        .then(Respuesta => {
          this.listaCia = Respuesta.data
          //console.log('listaGrupoCia', listaGrupoCia)
        })
        .catch(error => {
          alert('Error trayendo las Compañias')
        })
    },

    GetGrupoCias () {
      this.listaGrupoCias = []
      GrupoCiasService.select(2)
        .then(Respuesta => {
          this.listaGrupoCias = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo los Grupos de Compañias')
        })
    },

    GetPaises () {
      this.listaPaises = []
      PaisService.select(2)
        .then(Respuesta => {
          this.listaPaises = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo los Paises')
        })
    },

    GetEstados (paisID) {
      this.listaEstados = []
      //console.log('paisID' + paisID)
      EstadoService.select(2, paisID)
        .then(Respuesta => {
          this.listaEstados = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo los Estados')
        })
    },

    GetCiudades (estadoID) {
      this.listaCiudades = []
      CiudadService.select(2, estadoID)
        .then(Respuesta => {
          this.listaCiudades = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo las Ciudades')
        })
    },

    GetMarcas () {
      this.listaMarcas = []
      DominioDetService.select(this.formCia.pais_id, 87, false, 2)
        .then(Respuesta => {
          this.listaMarcas = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo las Marcas')
        })
    },

    GetTipos () {
      this.listaTipos = []
      DominioDetService.select(this.formCia.pais_id, 166, false, 2)
        .then(Respuesta => {
          this.listaTipos = Respuesta.data
          //console.log(listaGrupoCias)
        })
        .catch(error => {
          alert('Error trayendo los Tipos')
        })
    },

    GetSoportes () {
      this.listaSoporte = []
      SoporteService.select(2)
        .then(Respuesta => {
          this.listaSoporte = Respuesta.data
        })
        .catch(error => {
          alert('Error trayendo los Tipos')
        })
    },

    // ADD --
    AddRegistro () {
      //console.log('llamando addregistro')
      let modelo = {
        rif: this.formCia.rif,
        nombre: this.formCia.nombre,
        grupo_cia_id: parseInt(this.formCia.grupo_cia_id),
        tipo_166_id: parseInt(this.formCia.tipo_166_id),
        pais_id: parseInt(this.formCia.pais_id),
        estado_id: parseInt(this.formCia.estado_id),
        ciudad_id: parseInt(this.formCia.ciudad_id),
        marca_87_id: parseInt(this.formCia.marca_87_id),
        soporte_id: parseInt(this.formCia.soporte_id),
        codigo_bd: this.formCia.codigo_bd,
        lic_alquiler: this.formCia.lic_alquiler,
        lic_vta: this.formCia.lic_vta,
        version_app: this.formCia.version_app,
        version_bd: this.formCia.version_bd,
        //activa: parseInt(this.formCia.activa),
        //bloqueada: parseInt(this.formCia.bloqueada),
        marca: this.formCia.marca
      }

      CiaService.add(modelo)
        .then(Response => {
          this.VentanaCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error agregando la Compañia')
        })
    },

    // Update --

    UpdateRegistro () {
      let modelo = {
        cia_id: this.formCia.cia_id,
        rif: this.formCia.rif,
        nombre: this.formCia.nombre,
        grupo_cia_id: parseInt(this.formCia.grupo_cia_id),
        tipo_166_id: parseInt(this.formCia.tipo_166_id),
        pais_id: parseInt(this.formCia.pais_id),
        estado_id: parseInt(this.formCia.estado_id),
        ciudad_id: parseInt(this.formCia.ciudad_id),
        marca_87_id: parseInt(this.formCia.marca_87_id),
        soporte_id: parseInt(this.formCia.soporte_id),
        codigo_bd: this.formCia.codigo_bd,
        lic_alquiler: this.formCia.lic_alquiler,
        lic_vta: this.formCia.lic_vta,
        version_app: this.formCia.version_app,
        version_bd: this.formCia.version_bd,
        activa: parseInt(this.formCia.activa),
        bloqueada: parseInt(this.formCia.bloqueada),
        marca: this.formCia.marca
      }
      CiaService.update(modelo, modelo.cia_id)
        .then(Response => {
          this.VentanaCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error editando la Compañia')
        })
    },

    // Delete --

    DeleteRegistro () {
      //console.log('borrar esta id: ' + this.formCiaBorrar.id)
      CiaService.remove(this.formCiaBorrar.id)
        .then(Response => {
          this.VentanaBorrarCerrar()
          this.GetRegistros()
        })
        .catch(error => {
          alert('Error borrando la Compañia')
        })
    },

    // ---------- VENTANAS -------------

    VentanaAgregar () {
      this.formCia.cia_id = ''
      this.formCia.nombre = ''
      this.formCia.grupo_cia_id = ''
      this.formCia.tipo_166_id = ''
      this.formCia.pais_id = ''
      this.formCia.estado_id = ''
      this.formCia.ciudad_id = ''
      this.formCia.soporte_id = ''
      this.formCia.marca_87_id = ''
      this.formCia.codigo_bd = ''
      this.formCia.lic_alquiler = ''
      this.formCia.lic_vta = ''
      this.formCia.version_app = ''
      this.formCia.version_bd = ''
      this.formCia.marca = ''
      this.formCia.activa = ''
      this.formCia.bloqueada = ''
      this.esNuevoRegistro = true
      this.modalAgregaEdita = true
    },

    VentanaEditar (item) {
      this.formCia.rif = item.rif
      this.formCia.cia_id = item.cia_id
      this.formCia.nombre = item.nombre
      this.formCia.grupo_cia_id = item.grupo_cia_id.toString()
      this.formCia.tipo_166_id = item.tipo_166_id.toString()
      this.formCia.pais_id = item.pais_id.toString()
      this.formCia.estado_id = item.estado_id.toString()
      this.formCia.ciudad_id = item.ciudad_id.toString()
      this.formCia.soporte_id = item.soporte_id.toString()
      this.formCia.marca_87_id = item.marca_87_id.toString()
      this.formCia.codigo_bd = item.codigo_bd
      this.formCia.lic_alquiler = item.lic_alquiler
      this.formCia.lic_vta = item.lic_vta
      this.formCia.version_app = item.version_app
      this.formCia.version_bd = item.version_bd
      this.formCia.marca = item.marca
      this.formCia.activa = item.activa
      this.formCia.bloqueada = item.bloqueada
      this.esNuevoRegistro = false
      this.modalAgregaEdita = true
    },

    VentanaLimpiar () {
      this.formCia.rif = ''
      this.formCia.cia_id = ''
      this.formCia.nombre = ''
      this.formCia.grupo_cia_id = ''
      this.formCia.tipo_166_id = ''
      this.formCia.pais_id = ''
      this.formCia.estado_id = ''
      this.formCia.ciudad_id = ''
      this.formCia.soporte_id = ''
      this.formCia.marca_87_id = ''
      this.formCia.codigo_bd = ''
      this.formCia.lic_alquiler = ''
      this.formCia.lic_vta = ''
      this.formCia.version_app = ''
      this.formCia.version_bd = ''
      this.formCia.marca = ''
      this.formCia.activa = ''
      this.formCia.bloqueada = ''
      this.esNuevoRegistro = true
    },

    VentanaCerrar() {
      this.VentanaLimpiar()
      this.modalAgregaEdita = false
    },

    VentanaBorrar(item) {
      this.formCiaBorrar.id = item.cia_id
      this.formCiaBorrar.nombre = item.nombre
      this.formCiaBorrar.mensaje = 'Desea borrar esta Compañia?'
      this.dialogBorrar = true
      //console.log('ventana borrar llamada con id: ' + this.formCiaBorrar.id)
    },

    VentanaBorrarCerrar() {
      this.formCiaBorrar.id = ''
      this.formCiaBorrar.nombre = ''
      this.formCiaBorrar.mensaje = ''
      this.dialogBorrar = false
    },

    // --------------- Otros ------------------------

    AceptarApretado() {
      //console.log('aceptar apretado')
      this.$v.formCia.$touch()
      if (this.$v.formCia.$error) {
        MyLibjt.msgSnackBar('Data Invalida', 'error')
      } else {
        this.GuardarOEditar()
      }
    },

    GuardarOEditar () {
      //console.log('guardo o edito')
      if (this.esNuevoRegistro === true) {
        this.AddRegistro()
      }else{
        this.UpdateRegistro()
      }
    }
  }
}

</script>