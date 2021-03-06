import axios from 'axios'
import store from '../../store'

class ciaService {
  constructor () {
    this.urlBase = 'api/Cias'
    this.user = store.state.usuario
    this.headerAut = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.headerToken }
    }
  }

  // GET: api/Cias
  getAll () {
    //console.log('llamando a getall cia')
    let self = this
    let url = self.urlBase
    return axios.get(url, self.headerBasic)
  }

  update (modelo, id) {
    let self = this
    let url = self.urlBase + '/' + `${id}`
    return axios.put(url, modelo, self.headerBasic)
  }

  add (modelo) {
    //console.log('llamando a add en ciaservice')
    //console.log(modelo)
    let self = this
    let url = self.urlBase
    return axios.post(url, modelo, self.headerBasic)
  }

  remove (id) {
    let self = this
    let url = self.urlBase + '/' + `${id}`
    return axios.delete(url, self.headerBasic)
  }

  bloquear (id) {
    let self = this
    let url = self.urlBase + '/' + `${id}` + '/Bloquear'
    return axios.put(url, self.headerBasic)
  }

  desbloquear (id) {
    let self = this
    let url = self.urlBase + '/' + `${id}` + '/Desbloquear'
    return axios.put(url, self.headerBasic)
  }

  cambiarStatus (id) {
    let self = this
    let url = self.urlBase + '/' + `${id}` + '/CambiarStatus'
    return axios.put(url, self.headerBasic)
  }

  select (tipo) {
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.urlBase + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new ciaService()
export {
  instance as CiaService
}