import axios from 'axios'
import store from '../../store'

class PersonaService {
  constructor () {
    this.url = 'api/Personas'
    this.user = store.state.usuario
    this.token = this.user.token_all
    this.headerAuth = store.state.headerToken
    this.headerBasic = {
      headers: { Authorization: self.token }
    }
  }

  get (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.get(url, {
      headers: { Authorization: self.token }
    })
  }

  getAll () {
    // { Authorization: self.token }
    //console.log('toy llamando getall tambn ps')
    let self = this
    let url = self.url + '/GetAllVM'
    //console.log('se trae la data en getAll. ' + url)
    let filtro = {
      cedula: '',
      nombre: '',
      correo: '',
      cargo: '',
      sexo: ''
    }
    return axios.get(url, { params: filtro, headers: { Authorization: self.token }})
  }

  add (model) {
    let self = this
    return axios.post(self.url, model, {
      headers: { Authorization: self.token }
    })
  }

  update (model) {
    let self = this
    let url = self.url
    return axios.put(url, model, {
      headers: { Authorization: this.token }
    })
  }

  remove (id) {
    let self = this
    let url = self.url + '/' + `${id}`
    return axios.delete(url, { headers: { Authorization: this.token }
    })
  }

  select (tipo) {
    let self = this
    let tipoSelect = (tipo === undefined) ? 0 : tipo
    let url = self.url + '/Select'
    return axios.get(url, { params: {tipo: tipoSelect}, headers: { Authorization: self.token }
    })
  }

}

const instance = new PersonaService()
export {
  instance as PersonaService
}