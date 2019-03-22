<template>
  <q-layout>

    <div class="row gutter-x-sm gutter-y-lg">

      <!-- hd_doc_id -->
      <div class="col-xs-5">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="hd_doc_id"
            required
            float-label="ID del Caso"
            v-model.trim="formCaso.hd_doc_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>


    </div>

    <div class="row gutter-x-sm gutter-y-lg">

      <!-- Titulo -->
      <div class="col-xs-5">
        <q-field :count="120" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="titulo"
            required
            float-label="Titulo"
            v-model.trim="formCaso.titulo"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- Numero -->
      <div class="col-xs-5">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="numero"
            required
            float-label="Numero"
            v-model.trim="formCaso.numero"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- Descripcion -->
      <div class="col-xs-10">
        <q-field :count="500" :error="$v.formCaso.descripcion.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="descripcion"
            required
            float-label="Descripcion"
            v-model.trim="formCaso.descripcion"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>

    <br><p> A - - - - - - - - - - - - - - - - - - - - - - - </p>

    <div class="row gutter-x-sm gutter-y-lg">

      <!-- Consultor -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="consultor_id"
            required
            float-label="Consultor"
            v-model.trim="formCaso.consultor_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- Programador -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="programador_id"
            required
            float-label="Programador"
            v-model.trim="formCaso.programador_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- Persona -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="persona_id"
            required
            float-label="Persona"
            v-model.trim="formCaso.persona_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- aplicacion_178_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="aplicacion_178_id"
            required
            float-label="Aplicacion?"
            v-model.trim="formCaso.aplicacion_178_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- urgencia_170_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="urgencia_170_id"
            required
            float-label="Nivel de Urgencia"
            v-model.trim="formCaso.urgencia_170_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- tipo_172_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="tipo_172_id"
            required
            float-label="Tipo"
            v-model.trim="formCaso.tipo_172_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- status_175_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="status_175_id"
            required
            float-label="Status"
            v-model.trim="formCaso.status_175_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- modulo_214_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="modulo_214_id"
            required
            float-label="Modulo"
            v-model.trim="formCaso.modulo_214_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- motivo_298_id -->
      <div class="col-xs-3">
        <q-field>
          <q-input
            :dark="oscuridad"
            ref="motivo_298_id"
            required
            float-label="Motivo"
            v-model.trim="formCaso.motivo_298_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>

    <br><br><p> A - - - - - - - - - - - - - - - - - - - - - - - </p>

    <div class="row gutter-x-sm gutter-y-lg">

      <!-- cia_id -->
      <div class="col-xs-5">
        <q-field :count="100" :error="$v.formCaso.cia.$error" :error-label="ErrorTitulo">
        <!-- <q-field> -->
          <q-input
            :dark="oscuridad"
            ref="cia_id"
            required
            float-label="Compañia"
            v-model.trim="formCaso.cia_id"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- pais_id -->
      <div class="col-xs-5">
        <q-field :count="1" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
                <q-select
                  filter
                  :dark="oscuridad"
                  v-model="formCaso.pais_id"
                  radio
                  float-label="Pais"
                  :options="listaPaises"
                />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- f_crea -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="f_crea"
            required
            float-label="Fecha de Creacion"
            v-model.trim="formCaso.f_crea"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- f_correcion -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="f_correcion"
            required
            float-label="Fecha de Correcion"
            v-model.trim="formCaso.f_correcion"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- f_solucion -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="f_solucion"
            required
            float-label="Fecha de Solucion"
            v-model.trim="formCaso.f_solucion"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- version_app -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="version_app"
            required
            float-label="Version de la Aplicacion"
            v-model.trim="formCaso.version_app"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- version_bd -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="version_bd"
            required
            float-label="Version de la Database"
            v-model.trim="formCaso.version_bd"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- solucion -->
      <div class="col-xs-5">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="solucion"
            required
            float-label="Solucion"
            v-model.trim="formCaso.solucion"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- version_solucion -->
      <div class="col-xs-5">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="version_solucion"
            required
            float-label="Version de la Solucion"
            v-model.trim="formCaso.version_solucion"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>
    <div class="row gutter-x-sm gutter-y-lg">

      <!-- nombre_contacto -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="nombre_contacto"
            required
            float-label="Nombre del Contacto"
            v-model.trim="formCaso.nombre_contacto"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- email_contacto -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="email_contacto"
            required
            float-label="Email del Contacto"
            v-model.trim="formCaso.email_contacto"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- tlf_contacto -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="tlf_contacto"
            required
            float-label="Telefono del Contacto"
            v-model.trim="formCaso.tlf_contacto"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>

    <br><p> A - - - - - - - - - - - - - - - - - - - - - - - </p>

    <div class="row gutter-x-sm gutter-y-lg">

      <!-- nombre_ventana -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="nombre_ventana"
            required
            float-label="Nombre de la Ventana"
            v-model.trim="formCaso.nombre_ventana"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- leido_consultor -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="leido_consultor"
            required
            float-label="Leido por el Consultor?"
            v-model.trim="formCaso.leido_consultor"
            :color="colorResaltado"
          />
        </q-field>
      </div>

      <!-- leido_programador -->
      <div class="col-xs-3">
        <q-field :count="100" :error="$v.formCaso.titulo.$error" :error-label="ErrorTitulo">
          <q-input
            :dark="oscuridad"
            ref="leido_programador"
            required
            float-label="Leido por el Programador?"
            v-model.trim="formCaso.leido_programador"
            :color="colorResaltado"
          />
        </q-field>
      </div>

    </div>

  </q-layout>
</template>

<script>
import { required, maxLength } from 'vuelidate/lib/validators'
import { MyLibjt } from '../../lib/libjt.js'
import { DominioDetService } from '../../lib/dominioDetService.js'
import { PaisService } from '../../lib/region/paisService.js'

export default {
  ////////////////////////////// DATA ////////////////////////////////
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

      formCaso: {
        hd_doc_id: '',
        consultor_id: '',
        programador_id: '',
        cia_id: '',
        persona_id: '',
        pais_id: '',
        aplicacion_178_id: '',
        urgencia_170_id: '',
        tipo_172_id: '',
        status_175_id: '',
        modulo_214_id: '',
        motivo_298_id: '',
        numero: '',
        titulo: '',
        f_crea: '',
        version_app: '',
        version_bd: '',
        f_correcion: '',
        solucion: '',
        version_solucion: '',
        f_solucion: '',
        nombre_contacto: '',
        email_contacto: '',
        tlf_contacto: '',
        nombre_ventana: '',
        leido_consultor: '',
        leido_programador: ''
      },

      listaPaises: []
    }
  },

 ////////////////////////////// VALIDATIONS ////////////////////////////////
  validations: {
    formCaso: {
      titulo: { required, maxLength: maxLength(120) },
      version_app: { maxLength: maxLength(12) },
      version_bd: { maxLength: maxLength(12) },
      version_solucion: { maxLength: maxLength(12) },
      nombre_contacto: { maxLength: maxLength(120) },
      email_contacto: { required, maxLength: maxLength(150) },
      tlf_contacto: { required, maxLength: maxLength(20) },
      nombre_ventana: { maxLength: maxLength(60) },
      descripcion: { maxLength: maxLength(500) },
      cia: { required }
    }
  },

  ////////////////////////////// COMPUTED ////////////////////////////////
  computed: {
    ErrorTitulo () {
      return ''
    }

  },


  ////////////////////////////// LIFE CYCLE ////////////////////////////////
  mounted () {
    this.GetPaises()
  },

  ////////////////////////////// METHOD ////////////////////////////////
  method: {

    // GET
    GetPaises () {
      this.listaPaises = []
      PaisService.select(2)
        .then(Respuesta => {
          this.listaPaises = Respuesta.data

        })
        .catch(error => {
          alert('Error trayendo los Paises')
        })
    }
  }

}
</script>
