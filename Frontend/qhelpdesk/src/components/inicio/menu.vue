<template>
  <q-layout view="lHh Lpr lFf">
    <q-layout-header>
      <q-toolbar
        color="primary"
        :glossy="$q.theme === 'mat'"
        :inverted="$q.theme === 'ios'"
      >
        <q-btn
          flat
          dense
          round
          @click="leftDrawerOpen = !leftDrawerOpen"
          aria-label="Menu"
        >
          <q-icon name="menu" />
        </q-btn>
        <q-toolbar-title>
          HelpDesk Infoauto
          <div slot="subtitle">{{ correo }}</div>
        </q-toolbar-title>
        <q-btn round color="black" @click="salirAplicacion" v-if="islogged">
          <q-icon name="logout" />
        </q-btn>

      </q-toolbar>
    </q-layout-header>

    <q-layout-drawer
      v-model="leftDrawerOpen"
      :content-class="$q.theme === 'mat' ? 'bg-grey-2' : null"
      v-if="islogged"
    >
      <q-list
        no-border
        link
        inset-delimiter
      >
        <q-list-header>Opciones de Menú</q-list-header>
        <q-item to="/">
          <q-item-side icon="home" />
        </q-item>
        <q-item to="/caso">
          <q-item-side icon="school" />
          <q-item-main label="Casos" sublabel="Manejo de casos" />
        </q-item>
      </q-list>
      <q-collapsible icon="inbox" label="Clientes">
        <q-item to="/grupocia">
          <q-item-side icon="school" />
          <q-item-main label="Grupos de compañías"/>
        </q-item>
        <q-item to="/cia">
          <q-item-side icon="school" />
          <q-item-main label="Compañías"/>
        </q-item>
        <q-item to="/sucursal">
          <q-item-side icon="school" />
          <q-item-main label="Sucursales"/>
        </q-item>
        <q-item to="/persona">
          <q-item-side icon="school" />
          <q-item-main label="Personas"/>
        </q-item>
      </q-collapsible>
      <q-collapsible icon="vpn_key" label="Acceso al Sistema">
        <q-item to="/roles">
          <q-item-side icon="school" />
          <q-item-main label="Roles"/>
        </q-item>
        <q-item to="/usuario">
          <q-item-side icon="account_circle" />
          <q-item-main label="Usuarios"/>
        </q-item>
        <q-item to="/cambiarpwd">
          <q-item-side icon="vpn_key" />
          <q-item-main label="Cambiar Clave"/>
        </q-item>
      </q-collapsible>
      <q-collapsible icon="location_city" label="Direcciones">
        <q-item to="/pais">
          <q-item-side />
          <q-item-main label="Paises"/>
        </q-item>
        <q-item to="/estado">
          <q-item-side/>
          <q-item-main label="Estados"/>
        </q-item>
        <q-item to="/ciudad">
          <q-item-side/>
          <q-item-main label="Ciudades"/>
        </q-item>
        <q-item to="/municipio">
          <q-item-side/>
          <q-item-main label="Municipios"/>
        </q-item>
      </q-collapsible>
      <q-item to="/salir">
        <q-item-side />
        <q-icon name="logout" />
        <q-item-main label="Salir"/>
      </q-item>
    </q-layout-drawer>
    <q-page-container>
      <login v-if="!islogged"></login>
      <router-view />
    </q-page-container>
  </q-layout>
</template>
<script>
import login from './login'
export default {
  name: 'MyLayout',
  components: {
    login: login
  },
  data () {
    return {
      leftDrawerOpen: this.$q.platform.is.desktop
    }
  },

  computed: {
    correo () {
      return this.$store.state.usuario.email
    },
    islogged () {
      return this.$store.state.islogged
    },
    user: function () {
      return this.$store.state.usuario
    },
    logueado () {
      return this.$store.state.islogged
    },
    esAdministrador () {
      return this.$store.state.islogged && this.$store.state.esAdministrador
    },
    esConsultor () {
      return this.$store.state.islogged && this.$store.state.esConsultor
    },
    esUsuario () {
      return this.$store.state.islogged && this.$store.state.esUsuario
    },
    esCXC () {
      return this.$store.state.islogged && this.$store.state.esCXC
    },
    rol () {
      return this.$store.state.usuario.rol
    },
    snackObj: function () {
      return this.$store.state.snackObj
    },
    alertajt: function () {
      return this.$store.state.objAlerta
    },
    buscando: function () {
      return false
      // return this.$store.state.buscandoDatos
    }
  },

  methods: {
    salirAplicacion () {
      this.$router.push({name: 'home'})
      this.$store.dispatch('salir')
    }
  }
}
</script>

<style>
</style>