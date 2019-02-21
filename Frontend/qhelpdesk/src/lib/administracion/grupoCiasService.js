import axios from 'axios'
import store from '../../store'

class grupoCiaService {
  constructor () {
    this.url = 'api/GrupoCias'
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerAuth = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.token }
    }
  }

  get (id) {
    let self = this
    let url = self.url + `${id}` + '/'
    return axios.get(url, headerBasic)
  }

  add (model) {
    let self = this
    let url = self.url
    return axios.post(url, model, headerBasic)
  }

  update (model) {
    let self = this
    let url = self.url
    return axios.put(url, model, headerBasic)
  }

  remove (id) {
    let self = this
    let url = self.url + `${id}` + '/'
    return axios.delete(url, headerBasic)
  }

  select (tipo) {
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.url + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new grupoCiaService()
export {
  instance as grupoCiaService
}