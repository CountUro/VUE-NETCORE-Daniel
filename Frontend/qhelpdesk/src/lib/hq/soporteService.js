import axios from 'axios'
import store from '../../store'

class soporteService {
  constructor () {
    this.urlBase = 'api/Soportes'
    this.user = store.state.usuario
    this.headerAut = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.headerToken }
    }
  }

  select (tipo) {
    //console.log('llamando soporteService select')
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.urlBase + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new soporteService()
export {
  instance as SoporteService
}