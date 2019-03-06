import axios from 'axios'
import store from '../../store'

class paisService {
  constructor () {
    this.urlBase = 'api/Paises'
    this.user = store.state.usuario
    this.headerAut = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.headerToken }
    }
  }

  select (tipo) {
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.urlBase + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new paisService()
export {
  instance as PaisService
}