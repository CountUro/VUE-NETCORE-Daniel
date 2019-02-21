import axios from 'axios'
import store from '../../store'

class RolService {
  constructor () {
    this.url = 'api/Roles' //RolesController
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerBasic = {
      headers: { Authorization: self.token }
    }
  }

  get (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.get(url, self.headerBasic)
  }

  getAll () {
    let self = this
    return axios.get(self.url, self.headerBasic) // self porque no se ha definido
  }

  add (modelo) {
    let self = this
    return axios.post(self.url, modelo, self.headerBasic)
  }

  update (modelo) {
    let self = this
    return axios.put(self.url, modelo, self.headerBasic)
  }

  remove (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.delete(url, self.headerBasic)
  }

  select (tipo = 2) {
    let self = this
    let url = self.url +'/Select'
    return axios.select(url, { params: {tipo: tipo}, headers: { Authorization: self.token } } )
  }
}

const instancia = new RolService()

export {
  instancia as RolService
}

