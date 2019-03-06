import axios from 'axios'
import store from '../../store'

class estadoService {
  constructor () {
    this.urlBase = 'api/Estados'
    this.user = store.state.usuario
    this.headerAut = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.headerToken }
    }
  }

  select (tipo, idEntrante) {
    let self = this
    let id = (idEntrante === undefined) ? 1862 : idEntrante
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.urlBase + '/Select' + '/' + `${id}`
    //console.log(url)
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }})
  }
}

const instance = new estadoService()
export {
  instance as EstadoService
}