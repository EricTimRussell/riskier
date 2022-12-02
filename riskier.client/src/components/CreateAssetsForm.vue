<template>

  <form @click.prevent="createAssets()">
    <div>
      <label for="infantry" class="form-label"></label>
      <input v-model="editable.infantry" type="number" id="infantry" hidden>
    </div>
    <button type="submit" class="btn btn-success">Generate Assets</button>
  </form>

</template>


<script>
import { ref } from "vue";
import { assetsService } from "../services/AssetsService";
import Pop from "../utils/Pop";

export default {
  setup() {
    const editable = ref({})
    return {
      editable,
      async createAssets() {
        try {
          const formData = editable.value
          assetsService.createAssets(formData)
        } catch (error) {
          Pop.error(error, "Creating Assets")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>