-------------------
<template>
  <div class="row justify-center items-center" style="margin-top:80px;">
    <div class="col-xs-12 col-md-3">
      <q-card>
        <q-card-media>
          <!-- <img src="../../assets/Infoauto_blanco.gif"> -->
        </q-card-media>
        <q-card-title color="primary">Entrada al Sistema Funcionando</q-card-title>
        <q-card-separator/>
        <q-card-main>
          <form ref="form">
            <q-field :count="150" icon="mail" icon-color="primary">
              <q-input
                type="email"
                ref="correo"
                float-label="Correo  (*)"
                v-model="form.correo"
                @blur="$v.form.correo.$touch"
                :error="$v.form.correo.$error"
              />
            </q-field>
            <q-field icon="vpn_key" icon-color="primary">
              <q-input
                ref="password"
                float-label="Clave (*)"
                type="password"
                v-model.trim="form.password"
                @blur="$v.form.password.$touch"
                :error="$v.form.password.$error"
              />
            </q-field>
            <div class="error" v-if="!$v.form.password.required">La clave es requerida</div>
          </form>
        </q-card-main>
        <q-card-separator/>
        <q-card-actions>
          <q-btn :disable="!formaValida" flat @click="logearse" color="primary" label="Entrar"/>
          <q-btn flat @click="pruebamsg" color="secundary" label="msg"/>
        </q-card-actions>
      </q-card>
    </div>
  </div>
</template>
<script>
import { MyLibjt } from '../../lib/libjt.js'
import { UsuarioService } from '../../lib/usuarioService.js'
import { required, email } from 'vuelidate/lib/validators'
export default {
  data () {
    return {
      form: {
        password: 'daniel123',
        correo: 'daniel@hotmail.com'
      },
      error: '',
      valid: false

    }
  },

  validations: {
    form: {
      correo: { required, email },
      password: { required }
    }
  },

  mounted () {
    this.form.correo = localStorage.getItem('correo')
    if (this.form.correo) {
      this.$refs.password.focus()
    } else {
      this.$refs.correo.focus()
    }
  },

  computed: {
    user: function () {
      return this.$store.state.usuario
    },
    urlBase: function () {
      return this.$store.state.url_base
    },
    snackObj: function () {
      return this.$store.state.snackObj
    },
    formaValida: function () {
      this.$v.form.$touch()
      let isFalse = false
      return (this.$v.form.$error) ? isFalse : true
    },
     islogged () {
      return this.$store.state.islogged
    }
  },
  methods: {
    logearse () {
      this.$v.form.$touch()
      if (this.$v.form.$error) {
        MyLibjt.notificacion('Los datos no son válidos', 'negative')
        return
      }
      this.peticionAjax()
    },

    peticionAjax () {
      // let miUrl = this.urlBase + 'api-token-auth/'
      // let url = 'https://localhost:44355/api/Usuarios/Login'
      let url = 'api/Usuarios/Login'
      let codObjeto = {
        email: this.form.correo,
        password: this.form.password
      }
      UsuarioService.login(codObjeto)
        .then(respuesta => {
          MyLibjt.notificacion('Login Exitoso', 'positive')
          this.postLogin(respuesta.data.token)
        })
        .catch(error => {
          MyLibjt.notificacion('Credenciales no válidos', 'negative')
          MyLibjt.manejoError('peticionAjax', error, false)
          //console.log('login error')
        })
    },

    postLogin (token) {
      UsuarioService.postLogin(token)
        .then(respuesta => {
          let miUser = respuesta.data
          this.$store.commit('setToken', token)
          this.$store.commit('setUsuario', miUser)
          localStorage.setItem('correo', this.form.correo)
          // this.setServiciosInit()
          // this.$router.push({name: 'home'})
        })
        .catch(error => {
          MyLibjt.notificacion('Error en postLogin', 'negative')
          MyLibjt.manejoError('postLogin', error, false)
        })
    },

    limpiarCampos (name) {
      this.$refs[name].resetFields()
    },

    setServiciosInit () {
      let user = this.$store.state.usuario
      let urlBase = this.$store.state.url_base
      // this.$store.state.services.ComunService.init(user)
      // this.$store.state.services.PaisService.init(user, urlBase)
      // this.$store.state.services.EstadoService.init(user, urlBase)
      // this.$store.state.services.CiudadService.init(user, urlBase)
      // this.$store.state.services.MunicipioService.init(user, urlBase)
      // this.$store.state.services.PersonaService.init(user, urlBase)
      // this.$store.state.services.DominioDetService.init(user, urlBase)
      // this.$store.state.services.UsuarioService.init(user, urlBase)
      // this.$store.state.services.RolService.init(user, urlBase)
      // this.$store.state.services.SoporteService.init(user, urlBase)
      // this.$store.state.services.GrupoCiaService.init(user, urlBase)
      // this.$store.state.services.CiaService.init(user, urlBase)
      // this.$store.state.services.SucursalService.init(user, urlBase)
      // this.$store.state.services.HdDocService.init(user, urlBase)
      // this.$store.state.services.HdDocDetService.init(user, urlBase)
      // this.$store.state.services.HdFileService.init(user, urlBase)
    },

    pruebamsg () {
      this.MsgResponse('Título del Alert', 'Mensaje del Alert', 'error', 'Regresar')
    },

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
  }
}
</script>
<style scoped>
.sombreado {
  background-color: rgb(63, 162, 196);
}
</style>