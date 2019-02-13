import axios from 'axios'
import store from '../store'

class DominioDetService {
  constructor () {
    this.url = 'api/DominioDets'
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerAuth = store.state.headerToken
  }

  select (IdPais, IdDominio, noAplica, tipo) {
    let self = this
    let url = self.url + '/Select'
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    // { Authorization: this.token }
    let regreso = axios.get(url, {
      params: {pais: IdPais, dominio: IdDominio, noaplica: noAplica, tipo: tipoSelect},
      headers: this.headerAuth
    })
    return regreso
  }
}

const instance = new DominioDetService()
export {
  instance as DominioDetService
}