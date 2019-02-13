import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

// export default new Vuex.Store({
  export default new Vuex.Store({
    state: {
      islogged: false,
      usuario: {
        token: '',
        token_all: '',
        rol_id: '',
        rol: '',
        pais_id: '',
        usuario_id: '',
        last_login: '',
        cia: '',
        email: '',
        nombre: '',
        is_active: '',
        tlf_movil: '',
        tlf_oficina: ''
      },

      msgError: {
        status: '',
        statusText: '',
        mensaje: ''
      },

      snackObj: {
        msg: '',
        modo: '',
        activar: false
      },

      objAlerta: {
        msg: '',
        titulo: '',
        modo: '',
        btnText: '',
        activar: false
      },

      headerToken: { Authorization: '' }
    },

    mutations: {
      setError (state, status, statusText, mensaje) {
        state.msgError.status = status
        state.msgError.statusText = statusText
        state.msgError.mensaje = mensaje
      },

      setLog (state, logeado) {
        state.islogged = logeado
      },

      setToken (state, token) {
        state.usuario.token = token
      },

      setearAlerta (state, objeto) {
        state.objAlerta.msg = objeto.msg
        state.objAlerta.modo = objeto.modo
        state.objAlerta.titulo = objeto.titulo
        state.objAlerta.btnText = objeto.btnText
        state.objAlerta.activar = true
      },

      setearSnackObj (state, objeto) {
        state.snackObj.msg = objeto.msg
        state.snackObj.modo = objeto.modo
        state.snackObj.activar = true
      },

      setUsuario (state, objUser) {
        state.usuario.token = state.usuario.token
        state.usuario.rol = objUser.rol.toLowerCase()
        state.usuario.rol_id = objUser.rol_id
        state.usuario.pais_id = objUser.pais_id
        state.usuario.token_all = 'Bearer ' + state.usuario.token
        state.usuario.usuario_id = objUser.usuario_id
        state.usuario.last_login = objUser.f_login
        state.usuario.email = objUser.email
        state.usuario.nombre = objUser.nombre
        state.usuario.is_active = objUser.activo
        state.usuario.tlf_movil = objUser.tlf_movil
        state.usuario.tlf_oficina = objUser.tlf_oficina
        state.headerToken.Authorization = 'Bearer ' + state.usuario.token
        state.islogged = true

        switch (objUser.rol.toLowerCase()) {
          case 'administrador':
            state.esAdministrador = true
            break
          case 'consultor':
            state.esConsultor = true
            break
          case 'cxc':
            state.esCxC = true
            break
          default:
            state.esUsuario = true
            break
        }
      },

      setSalir (state) {
        state.usuario.rol = ''
        state.usuario.token = ''
        state.usuario.token_all = ''
        state.usuario.usuario_id = ''
        state.usuario.last_login = ''
        state.usuario.email = ''
        state.usuario.name = ''
        state.usuario.is_active = ''
        state.usuario.tlf_movil = ''
        state.usuario.tlf_oficina = ''
        state.headerToken.Authorization = ''
        state.islogged = false
      }
    },

    actions: {
      snackSet ({commit}, miObj) {
        commit('setearSnackObj', miObj)
      },
      guardarToken ({commit}, token) {
        commit('setToken', token)
        // commit('setUsuario', decode(token))
        localStorage.setItem('token', token)
      },
      autoLogin ({commit}) {
        // let token = localStorage.getItem('token')
        // if (token){
        //   commit('setToken', token)
        //   commit('setUsuario', decode(token))
        // }
        // $router.push('/login')
      },
      salir ({commit}) {
        // commit('setToken', null)
        // commit('setUsuario', null)
        // localStorage.removeItem('token')
        commit('setSalir')
        // router.push('/login')
        // router.push({name: '/index'})
      }
    }
  })


  // import Vue from "vue";
  // import Vuex from "vuex";

  // Vue.use(Vuex);

  // export default new Vuex.Store({
  //   state: {},
  //   mutations: {},
  //   actions: {}
  // });