<template>
  <m-container>
    <m-list ref="listRef" :title="title" :icon="icon" :cols="cols" :query-model="model" :query-method="query">
      <template #querybar>
	      <!--查询条件-->
      </template>
      <template #buttons>
        <m-button-add :code="buttons.add.code" @click="add" />
      </template>
      <template #operation="{ row }">
        <m-button-edit :code="buttons.edit.code" @click="edit(row)" @success="refresh"></m-button-edit>
        <m-button-delete :code="buttons.remove.code" :action="remove" :data="row.id" @success="refresh"></m-button-delete>
      </template>
    </m-list>
    <save :id="selection.id" v-model="saveVisible" :mode="mode" @success="refresh" />
  </m-container>
</template>
<script>
import { useList, entityBaseCols } from 'mkh-ui'
import { reactive } from 'vue'
import { title, icon, buttons } from './page.json'
import Save from '../save/index.vue'
export default {
  components: { Save },
  setup() {
    const { query, remove } = mkh.api.sitemanager.dbrecord
    const model = reactive({ type: '' })
    const cols = [
      { prop: 'id', label: '编号', width: '55', show: false },
      { prop: 'name', label: 'Username' },
      { prop: 'pwd', label: 'Password' },
	  ...entityBaseCols,
    ]

    const list = useList()

    return {
      title,
      icon,
      buttons,
      model,
      cols,
      query,
      remove,
      ...list,
    }
  },
}
</script>
