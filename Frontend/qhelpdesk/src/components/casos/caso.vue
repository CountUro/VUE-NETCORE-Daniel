<template>
  <q-layout>

    <!------------------------------- INICIO - PESTAÑAS - INICIO ------------------------------------->
    <q-tabs v-model="tabSeleccionada" :color="colorFondoDos" :text-color="colorLetras">
      <q-tab slot="title" name="busqueda" label="Búsqueda"/>
      <q-tab slot="title" name="fich" :label="AgregaOEdita"/>
      <q-tab slot="title" name="hist" label="Detalles" :hidden="ExisteId" />
      <q-tab slot="title" name="files" label="Archivos" :hidden="ExisteId" />

    <!------------------------------- ?????????? ------------------------------------->
      <q-tab-pane name="busqueda" >
        <busqueda
          v-on:seleccionadoCaso="seleccionadoID($event)"
        >
        </busqueda>
      </q-tab-pane>

      <!--------  Ficha   --------->
      <q-tab-pane name="fich">
        <ficha :id="hd_doc_id" v-on:creandoCaso="nuevoCaso($event)" >
        </ficha> <!-- El nombre del tag es el que hace relacion al componente. -->
      </q-tab-pane>

      <!--------  Detalles   --------->
      <q-tab-pane name="hist">
        <historico :id="hd_doc_id" ></historico>
      </q-tab-pane>

      <!--------  Archivos   --------->
      <q-tab-pane name="files">
        <archivos :id="hd_doc_id" ></archivos>
      </q-tab-pane>

    </q-tabs>
    <!------------------------------- FINAL - PESTAÑAS - FINAL ------------------------------------->




  </q-layout>
</template>

    <!-- --------------------------------------------------------------------------------------------------------------------------- -->
    <!-- ------------------------------------------     SCRIPT            ---------------------------------------------------------- -->
    <!-- --------------------------------------------------------------------------------------------------------------------------- -->

<script>
////////////////////////////// IMPORTS ////////////////////////////////
import busqueda from './casoBusqueda.vue'
import ficha from './casoFicha.vue'
import archivos from './casoFiles'
import historico from './casoHistorico.vue'

export default {
  ////////////////////////////// DATA ////////////////////////////////
  components: {
    busqueda: busqueda, // componentes importados para usar aqui mismo
    ficha: ficha,
    archivos: archivos,
    historico: historico
  },

  ////////////////////////////// DATA ////////////////////////////////
  data () {
    return {
      colorBotones: 'primary',
      colorLetras: 'light',
      colorFondo: 'dark',
      colorFondoDos: 'faded',
      colorResaltado: 'info',

      oscuridad: 'dark',

      tabSeleccionada: 'buesquedaTab', // la tab seleccionada por defecto es busqueda
      hd_doc_id: '' // el doc por defecto es ninguno. nulo.
    }
  },

  ////////////////////////////// COMPUTED ////////////////////////////////
  computed: {
    ExisteId () {
      return (this.hd_doc_id)? true: false
    },
    AgregaOEdita () {
      return (!this.hd_doc_id)? 'Agregar Caso': 'Editar Caso' // Si es nulo, agrega, si no edita
    }
  },

  ////////////////////////////// METHODS ////////////////////////////////
  methods: {
    seleccionadoID (idCaso) {
      this.hd_doc_id = idCaso // cambiar tab a "editar"?
      this.tabSeleccionada = 'ficha'
    },

    nuevoCaso (id) {
      this.hd_doc_id = id
    }
  }
}
</script>
