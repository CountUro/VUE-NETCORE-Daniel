import axios from 'axios'
import store from '../../store'

class UsuarioService {
  constructor () {
    this.url = 'api/Usuarios'
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerAuth = store.state.headerToken
  }

  async get(id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.get(url, { headers: this.headerAuth })
  }

  async getAll(rol_id, soporte_id, nombre, correo, movil, oficina, activo) {
    let self = this
    let url = self.url + '/'
    return axios.get(url, {
      params: {
        rol: rol_id,
        soporte: soporte_id,
        nombre: nombre,
        correo: correo,
        movil: movil,
        oficina: oficina,
        activo: activo,
        programador: -1
      },
      headers: this.headerAuth
    })
  }

  async add(model) {
    let self = this
    return axios.post(self.url, model, { headers: this.headerAuth })
  }

  async update(model) {
    let self = this
    let url = self.url
    return axios.put(url, model, { headers: this.headerAuth })
  }

  async remove(id) {
    let self = this
    let url = self.url + "/" + `${id}`
    return axios.delete(url, { headers: this.headerAuth })
  }

  async cambiarClaveAdmin (user_id_conectado, IdUser, passwordNew) {
    let self = this
    let url = self.url + '/CambiarPwAdm'
    let objeto = {
      user_id_conectado: user_id_conectado,
      usuario_id: IdUser,
      password: passwordNew
    }
    return axios.put(url, objeto, { headers: this.headerAuth })
  }

  async cambiarClaveUsuario (modelo) {
    let self = this
    let url = self.url + '/CambiarPw'
    return axios.put(url, modelo, { headers: this.headerAuth })
  }

  async activarDesactivar (id, accion) {
    let self = this
    let url = self.url + '/CambiarStatus'
    let objeto = {
      id: id,
      activar: accion
    }
    return axios.put(url, objeto, { headers: this.headerAuth })
  }

  async select (tipo) {
    let self = this
    let url = self.url + '/select'
    return axios.get(url, { params: { tipo: tipo  }, headers: this.headerAuth })
  }

  async login (modelo) {
    //console.log('login iniciando en frontend')
    let self = this
    let url = self.url + '/Login'
    return axios.post(url, modelo, { headers: { 'Content-Type': 'application/json' } })
  }

  async postLogin (token) {
    let self = this
    let url = self.url + '/PostLogin'
    return axios.get(url, { headers: { Authorization: 'Bearer ' + token } })
  }

}

const instance = new UsuarioService()
export {
  instance as UsuarioService
}