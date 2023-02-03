<template>
  <form @submit.prevent="formCarrierGroup()">
    <div class="form-floating mb-3">
      <input v-model="editable.carrierNumber" required type="text" maxlength="2" class="form-control" id="carrierNumber"
        placeholder="1,2,3..." autocomplete="off">
      <label for="carrierNumber">Carrier Number...</label>
    </div>
    <div>
      <h2>Aircraft</h2>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot1" required class="form-select" id="unitSlot1"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot1">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot2" required class="form-select" id="unitSlot2"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot2">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot3" required class="form-select" id="unitSlot3"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot3">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot4" required class="form-select" id="unitSlot4"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot4">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot5" required class="form-select" id="unitSlot5"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot5">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot6" required class="form-select" id="unitSlot6"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot6">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot7" required class="form-select" id="unitSlot7"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot7">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot8" required class="form-select" id="unitSlot8"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option value="Fighter">Fighter ( {{ account.fighterAircraft }} )</option>
        <option value="CAS">CAS ( {{ account.closeAirSupport }} )</option>
      </select>
      <label for="unitSlot8">Select Unit Type</label>
    </div>
    <div>
      <h2>Ground Units Onboard</h2>
    </div>
    <div class="form-floating">
      <select v-model="editable.groundUnit1" class="form-select" id="groundUnit1" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit1">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.groundUnit2" class="form-select" id="groundUnit2" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit2">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.groundUnit3" class="form-select" id="groundUnit3" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit3">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.groundUnit4" class="form-select" id="groundUnit4" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit4">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.groundUnit5" class="form-select" id="groundUnit5" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit5">Select Unit Type</label>
    </div>
    <div class="form-floating mt-3">
      <select v-model="editable.groundUnit6" class="form-select" id="groundUnit6" aria-label="Select Unit for Slot">
        <option value="None">None</option>
        <option value="Infantry">Infantry</option>
        <option value="Special Forces">Special Forces</option>
        <option value="Mech">Mech</option>
        <option value="IFV">IFV</option>
        <option value="MBT">MBT</option>
        <option value="Artillery">Artillery</option>
        <option value="Anti-Aircraft">Anti-Aircraft</option>
      </select>
      <label for="groundUnit6">Select Unit Type</label>
    </div>
    <div class="modal-footer">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
      <button type="submit" class="btn btn-success">Form Group</button>
    </div>
  </form>
</template>


<script>
import { ref } from "vue";
import { AppState } from "../AppState";
import { computed } from "@vue/reactivity";
import Pop from "../utils/Pop";
import { navyUnitsService } from "../services/NavyUnitsService";
import { Modal } from "bootstrap";

export default {
  setup() {
    const editable = ref({})

    return {
      editable,

      account: computed(() => AppState.account),

      async formCarrierGroup() {
        try {
          const formData = editable.value
          await navyUnitsService.formCarrierGroup(formData)
          Modal.getOrCreateInstance('#formCarrierGroup').hide()
          editable.value = {}
        } catch (error) {
          Pop.error(error, "Forming Carrier Group")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>