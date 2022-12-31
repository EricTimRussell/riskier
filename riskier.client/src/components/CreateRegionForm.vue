<template>
  <form @submit.prevent="createRegion()">
    <div class="form-floating mb-3">
      <input v-model="editable.regionNumber" required type="text" maxlength="2" class="form-control" id="regionNumber"
        placeholder="1,2,3...">
      <label for="regionNumber">Region Number...</label>
    </div>
    <div hidden>
      <label for="capital" class="form-label">Capital: {{ editable.capital }}</label>
      <input v-model="editable.capital" type="range" class="form-range" min="1" max="15" step="1" id="capital" disabled>
    </div>
    <div hidden class="my-3">
      <label for="industry" class="form-label">Industry: {{ editable.industry }}</label>
      <input v-model="editable.industry" type="range" class="form-range" min="1" max="15" step="1" id="industry"
        disabled>
    </div>
    <div hidden class="mb-3">
      <label for="agriculture" class="form-label">Agriculture: {{ editable.agriculture }}</label>
      <input v-model="editable.agriculture" type="range" class="form-range" min="1" max="15" step="1" id="agriculture"
        disabled>
    </div>
    <div class="modal-footer">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
      <button type="submit" class="btn btn-success">Create</button>
    </div>
  </form>
</template>


<script>
import { Modal } from "bootstrap";
import { ref } from "vue";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";

export default {
  setup() {
    const editable = ref({ capital: Math.floor(Math.random() * 6 + 1), industry: Math.floor(Math.random() * 6 + 1), agriculture: Math.floor(Math.random() * 6 + 1) })
    return {
      editable,
      async createRegion() {
        try {
          const formData = editable.value
          await regionTilesService.createRegion(formData)
          editable.value = ({ capital: Math.floor(Math.random() * 6 + 1), industry: Math.floor(Math.random() * 6 + 1), agriculture: Math.floor(Math.random() * 6 + 1) })
          Modal.getOrCreateInstance('#createRegion').hide()
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