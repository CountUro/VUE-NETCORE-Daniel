import axios from 'axios'
import store from '../../store'

class grupoCiaService {
  constructor () {
    this.url = 'api/GrupoCias'
    this.urlBase = this.url
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerAuth = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.token }
    }
  }

  getAll () {
    //console.log('llamando a get en service')
    let self = this
    let url = self.urlBase
    //console.log('url' + url)
    return axios.get(url, {
      headers: { Authorization: self.token }
    })
  }

  add (model) {
    let self = this
    let url = self.urlBase
    //console.log('pasando por add')
    console.log('model ' + model)
    return axios.post(url, model, {
      headers: { Authorization: self.token }
    })
  }

  update (model, id) {
    let self = this
    let url = self.urlBase + '/' + `${id}`
    return axios.put(url, model, {
      headers: { Authorization: self.token }
    })
  }

  remove (id) {
    let self = this
    let url = self.urlBase + '/' + `${id}`
    //console.log('url ' + url)
    return axios.delete(url, {
      headers: { Authorization: self.token }
    })
  }

  select (tipo) {
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.urlBase + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new grupoCiaService()
export {
  instance as GrupoCiasService
}