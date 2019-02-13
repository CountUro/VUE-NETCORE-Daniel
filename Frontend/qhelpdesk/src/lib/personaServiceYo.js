import axios from 'axios'
import store from '../store'

class PersonaService {
  constructor () {
    this.url = 'api/Personas'
    this.user = store.state.usuario
    this.headerAut = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.token }
    }
  }

  get (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.get(url, this.headerBasic)
  }

  getAll () {
    let self = this
    let url = self.url + '/GetAllVM'
    return axios.get(url, this.headerBasic)
  }

  // post, como en personaService.cs
  add (modelo) {
    let self = this
    return axios.post(url, modelo, this.headerBasic)
  }

  update (modelo) {
    let self = this
    return axios.put(url, modelo, this.headerBasic)
  }

  remove (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.delete(url, this.headerBasic)
  }

  // funcion personalizada
  select (tipo = 0) {
    let self = this
    let url = self.url + '/Select'
    return axios.get(url, { params: {tipo: tipo}, headers: { Authorization: self.token }})
  }

}

const miInstancia = new PersonaService()

export {
  miInstancia as PersonaService
}