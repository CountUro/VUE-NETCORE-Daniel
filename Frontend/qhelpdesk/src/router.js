import Vue from 'vue'
import Router from 'vue-router'

import Menu from './components/inicio/menu.vue'
import Login from './components/inicio/login.vue'
import Salir from './components/inicio/salir.vue'
import Home from './views/Home.vue'
import About from './views/About.vue'

import Persona from './components/persona/persona.vue'
// import Caso from './components/caso/caso.vue'
 import Rol from './components/acceso/rol.vue'
// import Usuario from './components/acceso/user.vue'
// import CambiarPwd from './components/acceso/cambiarpwd.vue'
// import Cia from './components/cia/cia.vue'
// import GrupoCia from './components/cia/grupocia.vue'
// import Sucursal from './components/cia/sucursal.vue'
// import Pais from './components/direccion/pais.vue'
// import Estado from './components/direccion/estado.vue'
// import Ciudad from './components/direccion/ciudad.vue'
// import Municipio from './components/direccion/municipio.vue'


import store from './store'

Vue.use(Router)

// export default new Router({
//   routes: [

var router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      component: Menu,
      children: [
        {
          path: '',
          name: 'home',
          component: Home
        },
        {
          path: '/about',
          name: 'about',
          component: About
        },
        {
          path: '/salir',
          name: 'salir',
          component: Salir
        },
        {
          path: '/persona',
          name: 'persona',
          component: Persona,
          meta :{
            administrador :true,
            usuario: true,
            consultor: true,
            cxc: true
          }
        },
        // {
        //   path: '/casos',
        //   name: 'casos',
        //   component: Caso,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        {
          path: '/roles',
          name: 'roles',
          component: Rol,
          meta :{
            administrador :true
          }
        }
        // {
        //   path: '/usuarios',
        //   name: 'usuarios',
        //   component: Usuario,
        //   meta :{
        //     administrador :true
        //   }
        // },
        // {
        //   path: '/cambiarpwd',
        //   name: 'cambiarpwd',
        //   component: CambiarPwd,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/cia',
        //   name: 'cias',
        //   component: Cia,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/grupocias',
        //   name: 'grupocias',
        //   component: GrupoCia,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // }
        // {
        //   path: '/sucursales',
        //   name: 'sucursales',
        //   component: Sucursal,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/paises',
        //   name: 'paises',
        //   component: Pais,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/estados',
        //   name: 'estados',
        //   component: Estado,
        //   meta :{
        //     administrador :true,
        //     usuario: true,
        //     consultor: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/ciudades',
        //   name: 'ciudades',
        //   component: Ciudad,
        //   meta :{
        //     administrador :true,
        //     consultor: true,
        //     usuario: true,
        //     cxc: true
        //   }
        // },
        // {
        //   path: '/municipios',
        //   name: 'municipios',
        //   component: Municipio,
        //   meta :{
        //     administrador :true,
        //     consultor: true,
        //     usuario: true,
        //     cxc: true
        //   }
        // }
        // { path: '*', name: 'home', component: Home }
      ]
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (to.matched.some(record => record.meta.libre)){
    next()
  } else if (store.state.esAdministrador){
    if (to.matched.some(record => record.meta.administrador)){
      next()
    }
  }else if (store.state.esConsultor){
    if (to.matched.some(record => record.meta.consultor)){
      next()
    }
  }else if (store.state.esUsuario){
    if (to.matched.some(record => record.meta.usuario)){
      next()
    }
  }else if (store.state.esCxC){
    if (to.matched.some(record => record.meta.cxc)){
      next()
    }
  }
  else{
    next({
      to: '/'
    })
  }
})

export default router