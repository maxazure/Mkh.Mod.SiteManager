<template>
  <m-form-dialog :model="model" :rules="rules" v-bind="bind" v-on="on">
    <el-row>
      <el-col :span="24">
        <el-form-item label="Username：" prop="name">
          <el-input v-model="model.name" clearable />
        </el-form-item>
        <el-form-item label="Password：" prop="pwd">
          <el-input v-model="model.pwd" clearable />
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
    const api = mkh.api.sitemanager.dbrecord

    const model = reactive({ name: '', pwd: '' })
    const rules = {
    }

    const autoFocusRef = ref()
    const { bind, on } = useSave({ title: 'Databases', props, api, model, emit })
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
