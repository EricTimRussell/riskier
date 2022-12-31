<template>
  <form @submit.prevent="createCity()">
    <div class="form-floating mb-3">
      <input v-model="editable.regionNumber" required type="text" maxlength="2" class="form-control" id="regionNumber"
        placeholder="1,2,3..." autocomplete="off">
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
      async createCity() {
        try {
          const formData = editable.value
          await regionTilesService.createRegion(formData)
          Modal.getOrCreateInstance('#createCity').hide()
          editable.value = {}
        } catch (error) {
          Pop.error(error, "Creating City Region")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>