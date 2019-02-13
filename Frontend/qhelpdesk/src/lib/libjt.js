// import ElementUI from 'element-ui'
// import 'element-ui/lib/theme-chalk/index.css'
// import locale from 'element-ui/lib/locale/lang/es'
// '../../store/store'
import axios from 'axios'
import moment from 'moment'
import store from '../store'
import {
  Notify,
  Dialog
} from 'quasar'

class MyLibjt {
  constructor () {
    this.url_base = ''
    this.token_all = ''
    this.user = {}
    this.leerDatosBase()
    this.token = this.user.token_all
  }

  async getAllCias () {
    // let self = this
    // this.user = store.state.usuario
    // console.log('user', this.user)
    let myArray = []
    let url = 'api/Cias'
    await axios.get(url, { headers: { Authorization: this.token }
    })
      .then(response => {
        myArray = response.data
      })
    return myArray
  }

  concatenaArray (myArray) {
    let regreso
    let myStr
    let primero = true
    for (let i in myArray) {
      myStr = myArray[i]
      if (!this.isNullOrEmpty(myStr)) {
        if (primero) {
          regreso = myStr
          primero = false
        } else {
          regreso = regreso + ' ' + myStr.trim()
        }
      }
    }
    return regreso
  }

  isNullOrEmpty (str) {
    if (str === undefined || str === null || str.trim() === '') {
      return true
    }
    return false
  }

  esPositivo (valor) {
    let numero = this.trueNumber(valor)
    let isFalse = false
    let regreso = (numero < 0) ? isFalse : true
    return regreso
  }

  esMayorQue (valor, largo) {
    let regreso = true
    if (this.isNullOrEmpty(valor)) {
      regreso = false
    } else {
      if (typeof valor === 'string') {
        if (valor === undefined) {
          regreso = false
        } else if (valor.trim().length === 0) {
          regreso = false
        } else if (valor.trim().length <= largo) {
          regreso = false
        }
      } else {
        regreso = false
      }
    }
    return regreso
  }

  // emailValido (email) {
  //   let re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  //   let regreso = re.test(email)
  //   return regreso
  // }

  queryFilter (val, ArrayClone, ArraySelect) {
    ArraySelect = []
    if (!val || val.length < 1) {
      ArraySelect = ArrayClone
    } else {
      let search = val.trim().toLowerCase()
      ArraySelect = ArraySelect.filter(elemento => elemento.text.toLowerCase().includes(search))
    }
  }

  manejoError (msg, error, tipo) {
    if (tipo === true) {
      console.log(msg, error)
    }
  }

  notificacion (msg, color) {
    // positive (for success), negative (for errors), warning and info.
    let tipo = 'info'
    switch (color) {
      case 'error':
        tipo = 'negative'
        break
      case 'success':
        tipo = 'positive'
        break
      case 'negative':
        tipo = 'negative'
        break
      case 'positive':
        tipo = 'positive'
        break
      case 'warning':
        tipo = 'warning'
        break
    }

    Notify.create({
      message: msg,
      type: tipo,
      position: 'top',
      timeout: 3000
    })
  }

  Alerta (titulo, msg) {
    let configObj = {
      title: titulo,
      message: msg,
      color: 'primary',
      preventClose: true

    }
    Dialog.create(configObj)
  }

  Confirmacion (titulo, msg) {
    let configObj = {
      title: titulo,
      message: msg,
      preventClose: true,
      ok: 'Si',
      cancel: 'Cancelar'
    }
    return Dialog.create(configObj)

    // this.$q.dialog({
    //   title: 'Confirm',
    //   message: 'Modern HTML5 front-end framework on steroids.',
    //   ok: 'Agree',
    //   cancel: 'Disagree'
    // }).then(() => {
    //   this.$q.notify('Agreed!')
    // }).catch(() => {
    //   this.$q.notify('Disagreed...')
    // })
  }

  alertaQ (titulo, msg) {
    // this.$q.dialog({
    //   title: titulo,
    //   message: msg
    // })
    console.log('error')
    Dialog.create({
      title: 'titulo',
      message: msg
    })
  }

  extensionFile (file) {
    let n = file.lastIndexOf('.')
    if (n <= 0) {
      return ''
    }
    let extension = file.substring(n + 1, n + 4)
    return extension
  }

  tipoFilePermitido (file) {
    let regreso = false
    // let n = file.lastIndexOf(".")
    // if (n <= 0) {
    //   return regreso
    // }
    // let extension = file.substring(n+1, n+4)
    let extension = this.extensionFile(file)
    extension = extension.toLowerCase()
    switch (extension) {
      case 'txt':
      case 'pdf':
      case 'doc':
      case 'docx':
      case 'xls':
      case 'xlsx':
      case 'pbd':
      case 'exe':
      case 'png':
      case 'jpg':
      case 'jpeg':
      case 'gif':
      case 'csv':
      case 'mp4':
      case 'avi':
        regreso = true
        break
    }
    return regreso
    // {".txt", "text/plain"},
    // {".pdf", "application/pdf"},
    // {".doc", "application/vnd.ms-word"},
    // {".docx", "application/vnd.ms-word"},
    // {".xls", "application/vnd.ms-excel"},
    // {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
    // {".pbd", "application/pbd"},
    // {".pbl", "application/pbl"},
    // {".exe", "application/exe"},
    // {".png", "image/png"},
    // {".jpg", "image/jpeg"},
    // {".jpeg", "image/jpeg"},
    // {".gif", "image/gif"},
    // {".csv", "text/csv"}
  }

  msgSnackBar (msg, modo) {
    this.notificacion(msg, modo)
    // let miObj = {
    //   msg: msg,
    //   modo: modo
    // }
    // // this.$store.commit('setearSnackObj', miObj)
    // store.commit('setearSnackObj', miObj)
  }

  MsgResponse (titulo, msg, modo, boton) {
    let color = 'primary'
    switch (modo) {
      case 'error':
        color = 'negative'
        break
      case 'success':
        color = 'primary'
        break
    }
    this.$q.dialog({
      title: titulo,
      message: msg,

      // optional
      color: color,

      // optional; we want an "OK" button
      ok: false, // takes i18n value, or String for "OK" button label

      // optional; we want a "Cancel" button
      // cancel: true, // takes i18n value, or String for "Cancel" button label
      cancel: boton,
      // optional; prevent user dismissal when not clicking on a Dialog button
      preventClose: true,

      noBackdropDismiss: true, // gets set to "true" automatically if preventClose is "true"
      noEscDismiss: true, // gets set to "true" automatically if preventClose is "true"

      // optional; stacks button vertically instead of horizontally (default)
      stackButtons: false,

      // optional; a position of the Dialog (top, bottom, left, right)
      position: 'top'
    })
      .then(() => {})
      .catch(() => {})
  }

  alerta (titulo, msg, modo, boton) {
    this.alertaQ(titulo, msg)
    // let miAlerta = {
    //   msg: msg,
    //   modo: (!modo) ? 'error' : modo,
    //   titulo: titulo,
    //   btnText: (!boton) ? 'Regresar' : boton
    // }
    // // this.$store.commit('setearAlerta', miAlerta)
    // store.commit('setearAlerta', miAlerta)
  }

  procesaError (error, nFuncion) {
    let regreso = ''
    if (error === undefined) {
      return regreso
    }
    if (error.data === undefined) {
      return regreso
    }
    if (error.data.error === undefined) {
      return regreso
    }
    if (error.response.data.error.msg !== undefined) {
      regreso = error.response.data.error.msg + ' '
      if (error.response.data.error.trace !== undefined) {
        // regreso = regreso.trim() + '\n' + error.response.data.error.trace
        regreso = `{regreso}
        {error.response.data.error.trace}`
      }
      return regreso
    }
    if (error.response.data !== undefined) {
      regreso = error.response.data + '. Status: ' + error.response.status.toString()
    } else {
      regreso = 'Error en la función: ' + nFuncion + '. Status: ' + error.response.status.toString()
    }
    return regreso
  }

  leerDatosBase () {
    this.user = store.state.usuario
    this.url_base = store.state.url_base
  }

  setDatosBase (urlBase, usuarioObj) {
    // this.url_base = urlBase
    // this.user = usuarioObj
  }

  isNumber (n) {
    return !isNaN(parseFloat(n)) && isFinite(n)
  }

  swappingBool (p1, hacerSwap) {
    let isFalse = false
    return hacerSwap ? (p1 ? isFalse : true) : p1
  }

  isValidDate (day, month, year) {
    // Los parametros day, month, year deben ser numeros
    var date = new Date()
    date.setFullYear(year, month - 1, day)
    // month - 1 since the month index is 0-based (0 = January)

    if (
      date.getFullYear() === year &&
      date.getMonth() === month + 1 &&
      date.getDate() === day
    ) {
      return true
    } else {
      return false
    }
  }

  primerDiaMes (fecha) {
    return new Date(fecha.getFullYear(), fecha.getMonth(), 1)
  }

  ultimoDiaMes (fecha) {
    return new Date(fecha.getFullYear(), fecha.getMonth() + 1, 0)
  }

  finalDia (fecha) {
    return new Date(
      fecha.getFullYear(),
      fecha.getMonth(),
      fecha.getDate(),
      23,
      59,
      59,
      999
    )
  }

  getEdad (fecha) {
    // let hoy = new Date()
    // let fn = new Date(this.paciente.fecha_nacimiento)
    // let years = this.$moment('20111031', 'YYYY-MM-DD').fromNow()
    // let day_as_milliseconds = 86400000
    // let years = moment().diff(fecha, 'years', false)
    let anos = moment().diff(fecha, 'years', false)
    let f1 = moment(fecha).add(anos, 'years')
    let meses = moment().diff(f1, 'months', false)
    let f2 = moment(f1).add(meses, 'months')
    let dias = moment().diff(f2, 'days', false)

    let returObj = {
      anos: anos,
      meses: meses,
      dias: dias
    }
    return returObj
  }

  chkFecha (fecha) {
    return fecha ? moment(fecha).format('YYYY-MM-DD') : undefined
  }

  asignarDate (fecha, formato, ivuew) {
    let regreso
    if (!fecha) {
      regreso = undefined
    } else {
      if (ivuew) {
        regreso = moment(fecha).format(formato)
      } else {
        regreso = fecha
      }
    }
    return regreso
  }

  trueBoolean (valor) {
    let regreso = false
    if (!valor) {
      regreso = false
    } else {
      let tipo = typeof valor
      switch (tipo) {
        case 'boolean':
          regreso = valor
          break
        case 'string':
          regreso = this.stringToBoolean(valor)
          break
        case 'number':
          if (valor >= 1) {
            regreso = true
          } else {
            regreso = false
          }
          break
        default:
          regreso = 0
      }
      // regreso = valor
    }
    return regreso
  }

  stringToBoolean (valor) {
    switch (valor.toLowerCase().trim()) {
      case 'true':
      case 'yes':
      case '1':
        return true
      case 'false':
      case 'no':
      case '0':
      case null:
        return false
      default:
        return Boolean(valor)
    }
  }

  trueNumber (valor) {
    let regreso = 0
    if (valor) {
      let tipo = typeof valor
      switch (tipo) {
        case 'string':
          if (this.isNumber(valor)) {
            regreso = Number.parseInt(valor, 10)
          } else {
            regreso = 0
          }
          break
        case 'number':
          regreso = valor
          break
        default:
          regreso = 0
      }
      // regreso = valor
    }
    return regreso
  }

  // -------------------------------------------------------------------------
  // getPersona64(myArrayDestino, tipoPersona, tipoSelect, errorObj) {
  //   this.getPersonas64Async(tipoPersona)
  //     .then(respuesta => {
  //       errorObj.status = 1
  //       let i
  //       let myArrayOrigen = respuesta.data
  //       switch (tipoSelect) {
  //         case 0:
  //           myArrayDestino = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArrayDestino.push({
  //               value: myArrayOrigen[i].persona_id,
  //               text: myArrayOrigen[i].nombre_comp
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArrayDestino.push({
  //               value: myArrayOrigen[i].persona_id.toString(),
  //               label: myArrayOrigen[i].nombre_comp
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getPersonas64Async(tipo64) {
  //   let url = this.url_base + 'Persona/'
  //   let json = await axios.get(url, {
  //     params: { grupo_eco: this.user.grupo_eco, tipo_64: tipo64 },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }

  // // -------------------------------------------------------------------------
  // // getTabDetEco (myArray, tipoTab, tipoSelect, errorObj) {
  // // }

  // getTabDetEco(myArray, tipoTab, tipoSelect, errorObj) {
  //   this.getTabDetEcoAsync(tipoTab)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 1:
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_eco_id,
  //               text: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //         case 2:
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_eco_id.toString(),
  //               label: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = 1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getTabDetEcoAsync(tipoTab) {
  //   let url = this.url_base + 'TabDetEco/'
  //   let json = await axios.get(url, {
  //     params: { grupoeco: this.user.grupo_eco, tab: tipoTab },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }

  // // -------------------------------------------------------------------------

  getDominiosSelect (myArray, myArrayClone, pais, dominio) {
    store.state.services.DominioDetService.selectAsync(pais, dominio, false)
      .then(respuesta => {
        // let localArray = []
        // localArray = respuesta.data
        // myArray = localArray.copyWithin(0)
        // myArrayClone = localArray.copyWithin(0)

        // myArray = []
        // myArrayClone = []
        // myArray = localArray
        // myArrayClone = localArray
        // return
        let myArrayOrigen = respuesta.data
        let i
        for (i in myArrayOrigen) {
          myArray.push({
            value: myArrayOrigen[i].value,
            text: myArrayOrigen[i].text
          })
          myArrayClone.push({
            value: myArrayOrigen[i].value,
            text: myArrayOrigen[i].text
          })
        }
      })
      .catch(error => {
        this.msgSnackBar('Error buscando la lista del dominio: ' + dominio.toString(), 'error')
        let msg = this.procesaError(error, 'getDominiosSelect')
        this.alerta('Error', msg, 'error', 'Regresar')
      })
  }

  // getDominios(myArray, dominio, errorObj) {
  //   this.getDominiosAsync(dominio)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             if (myArrayOrigen[i].codigo !== 0) {
  //               myArray.push({
  //                 value: myArrayOrigen[i].dominio_det_id,
  //                 text: myArrayOrigen[i].descripcion
  //               })
  //             }
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             if (myArrayOrigen[i].codigo !== 0) {
  //               myArray.push({
  //                 value: myArrayOrigen[i].dominio_det_id.toString(),
  //                 label: myArrayOrigen[i].descripcion
  //               })
  //             }
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getDominiosAsync(dominio) {
  //   let url = this.url_base + 'DominioDet/'
  //   let json = await axios.get(url, {
  //     params: { pais: this.user.pais_id, dominio: dominio },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }

  // // -------------------------------------------------------------------------

  // getMonedas(myArray, tipoSelect, errorObj) {
  //   this.getMonedasAsync()
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].moneda_id,
  //               text: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview Element
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].moneda_id.toString(),
  //               label: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getMonedasAsync() {
  //   let url = this.url_base + 'Moneda/'
  //   let json = await axios.get(url, {
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }

  // // -------------------------------------------------------------------------

  // getTabDetDpto(myArray, dpto, tipoTab, tipoSelect, errorObj) {
  //   this.getTabDetDptoAsync(dpto, tipoTab)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_dpto_id,
  //               text: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_dpto_id.toString(),
  //               label: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getTabDetDptoAsync(dpto, tipoTab) {
  //   let url = this.url_base + 'TabDetDpto/'
  //   let json = await axios.get(url, {
  //     params: { departamento: dpto, tab: tipoTab },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------

  // getTabDetCia(myArray, cia, tipoTab, tipoSelect, errorObj) {
  //   this.getTabDetCiaAsync(cia, tipoTab)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_cia_id,
  //               text: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tab_det_cia_id.toString(),
  //               label: myArrayOrigen[i].descripcion
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getTabDetCiaAsync(cia, tipoTab) {
  //   let url = this.url_base + 'TabDetCia/'
  //   let json = await axios.get(url, {
  //     params: { cia: cia, tab: tipoTab },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getDptoCia(myArray, cia, tipoSelect, errorObj) {
  //   this.getDptoCiaAsync(cia)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id,
  //               text: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id.toString(),
  //               label: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getDptoCiaAsync(cia) {
  //   let url = this.url_base + 'Departamento/'
  //   let json = await axios.get(url, {
  //     params: { cia: cia },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getDptoCiaTipo(myArray, cia, tipoDpto, tipoSelect, errorObj) {
  //   this.getDptoCiaTipoAsync(cia, tipoDpto)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id,
  //               text: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id.toString(),
  //               label: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getDptoCiaTipoAsync(cia, tipoDpto) {
  //   let tipo = '4'
  //   switch (tipoDpto) {
  //     case 'R':
  //       tipo = '1'
  //       break
  //     case 'S':
  //       tipo = '2'
  //       break
  //     case 'V':
  //       tipo = '3'
  //       break
  //     case 'A':
  //       tipo = '4'
  //       break
  //     case 'T':
  //       tipo = undefined
  //       break
  //     default:
  //       console.log('No existe este tipo de departamento')
  //       return
  //   }

  //   let url = this.url_base + 'Departamento/'
  //   let codObjeto = {
  //     cia_id: cia,
  //     tipos2: tipo
  //   }
  //   let json = await axios.post(url, codObjeto, {
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getDptoCiaTipoArray(myArray, cia, tipoDpto, tipoSelect, errorObj) {
  //   this.getDptoCiaTipoArrayAsync(cia, tipoDpto)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id,
  //               text: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].departamento_id.toString(),
  //               label: myArrayOrigen[i].nombre
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }

  // async getDptoCiaTipoArrayAsync(cia, tipoDpto) {
  //   let url = this.url_base + 'dptocia/'
  //   let codObjeto = {
  //     cia_id: this.user.cia,
  //     tipos2: tipoDpto
  //   }
  //   let json = await axios.post(url, codObjeto, {
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }

  // // -------------------------------------------------------------------------

  // getUsers27Dpto(myArray, dpto, tipoUser, tipoSelect, errorObj) {
  //   this.getUsers27DptoAsync(dpto, tipoUser)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       // this.llenaSelectMonedas(respuesta.data, myArray, tipoSelect)
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].id,
  //               text: myArrayOrigen[i].name
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].id.toString(),
  //               label: myArrayOrigen[i].name
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }
  // async getUsers27DptoAsync(dpto, tipo) {
  //   let url = this.url_base + 'user27dpto/'
  //   let json = await axios.get(url, {
  //     params: { departamento: dpto, tipo: tipo },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getBancoCtas(myArray, tipoSelect, errorObj) {
  //   this.getBancoCtasAsync()
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       let descri
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             descri =
  //               myArrayOrigen[i].nombrebanco.trim() +
  //               ' - Cta: ' +
  //               myArrayOrigen[i].nro_cta.trim()
  //             myArray.push({
  //               value: myArrayOrigen[i].banco_cta_id,
  //               text: descri,
  //               moneda: myArrayOrigen[i].moneda_id
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             descri =
  //               myArrayOrigen[i].nombrebanco.trim() +
  //               ' - Cta: ' +
  //               myArrayOrigen[i].nro_cta.trim()
  //             myArray.push({
  //               value: myArrayOrigen[i].banco_cta_id.toString(),
  //               label: descri,
  //               moneda: myArrayOrigen[i].moneda_id
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }
  // async getBancoCtasAsync() {
  //   let url = this.url_base + 'banco/getBancoCtas/'
  //   let json = await axios.get(url, {
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getTarjetasPorTipo(myArray, tipo, tipoSelect, errorObj) {
  //   this.getTarjetasPorTipoAsync(tipo)
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tarjeta_id,
  //               text: myArrayOrigen[i].nombretarjeta
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tarjeta_id.toString(),
  //               label: myArrayOrigen[i].nombretarjeta
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }
  // async getTarjetasPorTipoAsync(tipo) {
  //   let url = this.url_base + 'banco/getTarjetas/'
  //   let json = await axios.get(url, {
  //     params: { tipo: tipo },
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // // -------------------------------------------------------------------------
  // getTarjetas(myArray, tipoSelect, errorObj) {
  //   this.getTarjetasAsync()
  //     .then(respuesta => {
  //       let myArrayOrigen = respuesta.data
  //       errorObj.status = 1
  //       var i
  //       switch (tipoSelect) {
  //         case 0:
  //           myArray = myArrayOrigen
  //           break
  //         case 1:
  //           // Bootstrap
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tarjeta_id,
  //               text: myArrayOrigen[i].nombretarjeta
  //             })
  //           }
  //           break
  //         case 2:
  //           // iview
  //           for (i in myArrayOrigen) {
  //             myArray.push({
  //               value: myArrayOrigen[i].tarjeta_id.toString(),
  //               label: myArrayOrigen[i].nombretarjeta
  //             })
  //           }
  //           break
  //       }
  //     })
  //     .catch(error => {
  //       errorObj.status = -1
  //       errorObj.mensaje =
  //         error.response.status + ' - ' + error.response.statusText
  //     })
  // }
  // async getTarjetasAsync() {
  //   let url = this.url_base + 'banco/getTarjetas/'
  //   let json = await axios.get(url, {
  //     headers: { Authorization: this.user.token_all }
  //   })
  //   return json
  // }
  // -------------------------------------------------------------------------

  // filtrarTabla (ArrayOrigen, ArrayFiltrado, ) {
  //   let search = this.filtrado
  //   search = search.trim().toLowerCase()
  //   this.datos = this.datosClone.filter(function (item) {
  //     return item.nro_cta.toLowerCase().includes(search)
  //   })
  // }

  // -------------------------------------------------------------------------

  // this.user = store.state.usuario
  // this.url_base = store.state.url_base
}

const instance = new MyLibjt()
export {
  instance as MyLibjt
}
