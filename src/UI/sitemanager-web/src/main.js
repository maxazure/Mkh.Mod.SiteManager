import {
  configure
} from 'mkh-ui'
import 'mkh-mod-admin'
import './index'

configure({
  http: {
    global: {
      baseURL: '/api/',
    },
  },
  beforeMount({
    config
  }) {
    config.component.login = 'k'
    config.site.title = ''
  },
})