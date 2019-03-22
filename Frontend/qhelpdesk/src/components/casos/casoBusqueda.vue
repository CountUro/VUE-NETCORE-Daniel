<template>
  <q-layout>
    <!-- -----------------------                LA TABLA                        ------------------------------ -->

    <q-layout-header>
      <q-table
      title="Lista de Casos"
      :data = listaCasos
      :columns = Columnas
      row-key = ""
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
            <q-btn size="md" icon="refresh" :color="colorBotones" class="q-mr-md" @click="GetCasos">
              <q-tooltip>Refrescar datos de la tabla</q-tooltip>
            </q-btn>

          </div>

          <!------------ Busqueda ------------>
          <div>
            <q-field :count="150" icon="search" :icon-color="colorBotones">
              <q-input :dark="oscuridad" v-model="filtro"/>
            </q-field>
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
export default {
  props: [
    'id'
  ],
  data () {
    return {
      // Colores por defecto oscuros
      colorBotones: 'primary',
      colorLetras: 'light',
      colorFondo: 'dark',
      colorFondoDos: 'faded',
      colorResaltado: 'info',

      oscuridad: 'dark',

      filtro: '',

      listaCasos: [],

      Columnas: [
        {
          name: 'editar',
          label: 'Editar',
          align: 'left'
        },

        {
          name: 'hd_doc_id',
          label: 'ID Documento',
          required: true,
          align: 'left',
          field: 'hd_doc_id',
          sortable: true
        },

        {
          name: 'titulo',
          label: 'Titulo',
          required: true,
          align: 'left',
          field: 'titulo',
          sortable: true
        },

        {
          name: 'urgencia_170_id',
          label: 'Nivel de Urgencia',
          required: true,
          align: 'left',
          field: 'urgencia_170_id',
          sortable: true
        },

        {
          name: 'urgencia_175_id',
          label: 'Estado',
          required: true,
          align: 'left',
          field: 'urgencia_175_id',
          sortable: true
        },

        {
          name: 'cia',
          label: 'Compañia',
          required: true,
          align: 'left',
          field: 'cia',
          sortable: true
        },

        {
          name: 'consultor',
          label: 'Consultor Responsable',
          required: true,
          align: 'left',
          field: 'consultor',
          sortable: true
        },

        {
          name: 'eliminar',
          label: 'Eliminar',
          align: 'left'
        },
      ]
    }
  },

  methods: {
    seleccionadoCaso (item) {
      this.$emit('seleccionoCaso', item.hd_doc_id)
      console.log('id: ' + hd_doc_id)
    },

    GetCasos () {
      this.listaCasos = []
    }
  }
}
</script>

