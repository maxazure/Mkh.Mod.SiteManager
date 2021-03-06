const {
  resolve
} = require('path')
const fs = require('fs')
const fse = require('fs-extra')
import {
  defineConfig
} from 'vite'
import vue from '@vitejs/plugin-vue'
import mkh from 'mkh-ui/lib/plugins'

//自定义预加载页
if (!fs.existsSync('./index.html')) {
  fse.copySync('node_modules/mkh-ui/entries/index.html', './index.html')
}

export default defineConfig(({
  mode,
  command
}) => {
  let config = {
    server: {
      port: 5240,
    },
    base: './',
    envPrefix: 'MKH',
    plugins: [
      mkh({
        mode,
        command,
        /** index.html文件转换 */
        htmlTransform: {
          /** 模板渲染数据，如果使用自己的模板，则自己定义渲染数据 */
          render: {
            //图标
            favicon: './assets/mkh/favicon.ico',
            /** 版权信息 */
            copyright: '17MKH',
            /** Logo */
            logo: './assets/mkh/logo.png',
          },
          /** 压缩配置 */
          htmlMinify: {},
        },
      }),
      vue(),
    ],
    css: {
      preprocessorOptions: {
        scss: {
          charset: false,
        },
      },
    },
  }

  //打包成库
  if (mode == 'lib') {
    //库模式需要取消复制静态资源目录
    config.publicDir = false

    config.build = {
      lib: {
        entry: resolve(__dirname, 'src/index.js'),
        formats: ['es'],
        fileName: 'index',
      },
      outDir: 'lib',
      rollupOptions: {
        /** 排除无需打包进去的依赖库 */
        external: ['vue', 'vue-router', 'vuex', 'mkh-ui'],
      },
    }
  } else if (mode == 'production') {
    config.build = {
      outDir: '../../WebHost/wwwroot/app',
    }
  }
  return config
})