<template>
  <form>
    <div>
      <label for="capital" class="form-label">Capital: {{ editable.capital }}</label>
      <input v-model="editable.capital" type="range" class="form-range" min="1" max="6" step="1" id="capital">
    </div>
  </form>
</template>


<script>
import { ref } from "vue";

export default {
  setup() {
    const editable = ref({})
    return {
      editable,
      async createRegion() {
        try {
          const formData = editable.value
          await regionTilesService.createRegion(formData)
          // TODO ADD MODAL close 
        } catch (error) {
          Pop.error(error, "Creating Region")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>