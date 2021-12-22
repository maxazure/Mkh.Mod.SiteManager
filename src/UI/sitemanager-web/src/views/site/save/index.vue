<template>
  <m-form-dialog :model="model" :rules="rules" v-bind="bind" v-on="on">
    <el-row>
      <el-col :span="24">
        <el-form-item label="站点名称：" prop="sitename">
          <el-input v-model="model.sitename" clearable />
        </el-form-item>
        <el-form-item label="域名：" prop="domain">
          <el-input v-model="model.domain" clearable />
        </el-form-item>
      </el-col>
    </el-row>
  </m-form-dialog>
</template>
<script>
import { reactive, ref } from 'vue'
import { useSave, withSaveProps } from 'mkh-ui'

export default {
  props: {
    ...withSaveProps,
  },
  setup(props, { emit }) {
    const api = mkh.api.sitemanager.site

    const model = reactive({ sitename: '', domain: '' })
    const rules = {
    }

    const autoFocusRef = ref()
    const { bind, on } = useSave({ title: '站点', props, api, model, emit })
    bind.autoFocusRef = autoFocusRef
    bind.width = '700px'
    bind.labelWidth = '150px'

    return {
      model,
      rules,
      bind,
      on,
      autoFocusRef,
    }
  },
}
</script>
