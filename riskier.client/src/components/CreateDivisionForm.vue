<template>
  <form @submit.prevent="formDivision()">
    <div class="form-floating mb-3">
      <input v-model="editable.divisionNumber" required type="text" maxlength="2" class="form-control"
        id="divisionNumber" placeholder="1,2,3...">
      <label for="divisionNumber">Division Number...</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot1" required class="form-select" id="unitSlot1"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot1">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot2" required class="form-select" id="unitSlot2"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot2">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot3" required class="form-select" id="unitSlot3"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot3">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot4" required class="form-select" id="unitSlot4"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot4">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot5" required class="form-select" id="unitSlot5"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot5">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot6" required class="form-select" id="unitSlot6"
        aria-label="Select Unit for Slot">
        <option selected></option>
        <option value="EmptySlot">EmptySlot</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="unitSlot6">Select Unit Type</label>
    </div>
    <div class="modal-footer">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
      <button type="submit" class="btn btn-success">Form Division</button>
    </div>
  </form>


</template>


<script>
import { ref } from "vue";
import Pop from "../utils/Pop";
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
export default {
  setup() {
    const editable = ref({})
    return {
      editable,
      async formDivision() {
        try {
          const formData = editable.value
          await armiesDivisionsService.formDivision(formData)
          editable.value = {}
        } catch (error) {
          Pop.error(error, "Creating Division")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>