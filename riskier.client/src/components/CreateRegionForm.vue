<template>
  <form @submit.prevent="createRegion()">
    <div class="form-floating mb-3">
      <input v-model="editable.regionNumber" required type="text" maxlength="2" class="form-control" id="regionNumber"
        placeholder="1,2,3...">
      <label for="regionNumber">Region Number...</label>
    </div>
    <div>
      <label for="capital" class="form-label">Capital: {{ editable.capital }}</label>
      <input v-model="editable.capital" type="range" class="form-range" min="1" max="15" step="1" id="capital">
    </div>
    <div class="my-3">
      <label for="industry" class="form-label">Industry: {{ editable.industry }}</label>
      <input v-model="editable.industry" type="range" class="form-range" min="1" max="15" step="1" id="industry">
    </div>
    <div class="mb-3">
      <label for="agriculture" class="form-label">Agriculture: {{ editable.agriculture }}</label>
      <input v-model="editable.agriculture" type="range" class="form-range" min="1" max="15" step="1" id="agriculture">
    </div>
    <div class="form-floating">
      <select v-model="editable.environment" required class="form-select" id="environment"
        aria-label="Select Region Environment">
        <option value="Grassland">Grassland</option>
        <option value="Desert">Desert</option>
        <option value="Forest">Forest</option>
        <option value="Highlands">Highlands</option>
        <option value="Wetlands">Wetlands</option>
        <option value="Jungle">Jungle</option>
        <option value="Urban">Urban</option>
      </select>
      <label for="environment">Select Region Environment</label>
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
    const editable = ref({ capital: 3, industry: 3, agriculture: 3 })
    return {
      editable,
      async createRegion() {
        try {
          const formData = editable.value
          await regionTilesService.createRegion(formData)
          editable.value = {}
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