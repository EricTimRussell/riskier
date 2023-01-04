<template>

  <body>
    <div class="bg-tan l-spacing elevation-5 carrier-card rounded p-1" v-if="carrierGroup.ownerId == account.id">
      <div>
        <div class="text-center">
          <h2>Carrier {{ carrierGroup.carrierNumber }}</h2>
        </div>
      </div>
      <div>
        <div>
          <h5 class="text-center">Aircraft Onboard</h5>
          <div class="d-flex justify-content-evenly">
            <h6>{{ carrierGroup.unitSlot1 }}</h6>
            <h6>{{ carrierGroup.unitSlot2 }}</h6>
          </div>
          <div class="d-flex justify-content-evenly">
            <h6>{{ carrierGroup.unitSlot3 }}</h6>
            <h6>{{ carrierGroup.unitSlot4 }}</h6>
          </div>
          <div class="d-flex justify-content-evenly">
            <h6>{{ carrierGroup.unitSlot5 }}</h6>
            <h6>{{ carrierGroup.unitSlot6 }}</h6>
          </div>
          <div class="d-flex justify-content-evenly">
            <h6>{{ carrierGroup.unitSlot7 }}</h6>
            <h6>{{ carrierGroup.unitSlot8 }}</h6>
          </div>
          <h5 class="pt-3 text-center">Ground Units Onboard</h5>
          <div class="d-flex justify-content-evenly">
            <h6 v-if="carrierGroup.groundUnit1 != null">{{ carrierGroup.groundUnit1 }}</h6>
            <h6 v-if="carrierGroup.groundUnit2 != null">{{ carrierGroup.groundUnit2 }}</h6>
          </div>
          <div class="d-flex justify-content-evenly">
            <h6 v-if="carrierGroup.groundUnit4 != null">{{ carrierGroup.groundUnit4 }}</h6>
            <h6 v-if="carrierGroup.groundUnit3 != null">{{ carrierGroup.groundUnit3 }}</h6>
          </div>
          <div class="d-flex justify-content-evenly">
            <h6 v-if="carrierGroup.groundUnit6 != null">{{ carrierGroup.groundUnit6 }}</h6>
            <h6 v-if="carrierGroup.groundUnit5 != null">{{ carrierGroup.groundUnit5 }}</h6>
          </div>
        </div>
      </div>
      <div class="d-flex justify-content-between">
        <button data-bs-toggle="modal" :data-bs-target="`#editCarrierGroup${carrierGroup.id}`"
          aria-label="Edit Carrier Group" class="btn no-shadow mdi mdi-cog fs-2"></button>
        <button @click="deleteCarrierGroup()" class=" btn mdi mdi-delete-forever fs-2 select no-shadow"
          title="Delete?"></button>
      </div>
    </div>


    <form @submit.prevent="editCarrierGroup()">
      <div class="modal fade text-dark l-spacing" :id="`editCarrierGroup${carrierGroup.id}`" tabindex="-1"
        aria-labelledby="editCarrierGroup" aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h1 class="modal-title fs-5">Edit Carrier Group {{ carrierGroup.carrierNumber }}</h1>
              <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
                title="close modal"></button>
            </div>
            <h5 class="text-center">Aircraft</h5>
            <div class="form-floating">
              <select v-model="editable.unitSlot1" required class="form-select" id="unitSlot1"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot1">Current Unit: {{ carrierGroup.unitSlot1 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot2" required class="form-select" id="unitSlot2"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot2">Current Unit: {{ carrierGroup.unitSlot2 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot3" required class="form-select" id="unitSlot3"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot3">Current Unit: {{ carrierGroup.unitSlot3 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot4" required class="form-select" id="unitSlot4"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot4">Current Unit: {{ carrierGroup.unitSlot4 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot5" required class="form-select" id="unitSlot5"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot5">Current Unit: {{ carrierGroup.unitSlot5 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot6" required class="form-select" id="unitSlot6"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot6">Current Unit: {{ carrierGroup.unitSlot6 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot7" required class="form-select" id="unitSlot7"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot7">Current Unit: {{ carrierGroup.unitSlot7 }}</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot8" required class="form-select" id="unitSlot8"
                aria-label="Select Unit for Slot">
                <option value="EmptySlot">EmptySlot</option>
                <option value="Fighter">Fighter</option>
                <option value="CAS">CAS</option>
              </select>
              <label for="unitSlot8">Current Unit: {{ carrierGroup.unitSlot8 }}</label>
            </div>
            <div>
              <h5 class="text-center">Ground Units</h5>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit1" class="form-select" id="groundUnit1"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit1">Current Unit: {{ carrierGroup.groundUnit1 }}</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit2" class="form-select" id="groundUnit2"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit2">Current Unit: {{ carrierGroup.groundUnit2 }}</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit3" class="form-select" id="groundUnit3"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit3">Current Unit: {{ carrierGroup.groundUnit3 }}</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit4" class="form-select" id="groundUnit4"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit4">Current Unit: {{ carrierGroup.groundUnit4 }}</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit5" class="form-select" id="groundUnit5"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit5">Current Unit: {{ carrierGroup.groundUnit5 }}</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.groundUnit6" class="form-select" id="groundUnit6"
                aria-label="Select Unit for Slot">
                <option value="Infantry">Infantry</option>
                <option value="Special Forces">Special Forces</option>
                <option value="Mech">Mech</option>
                <option value="IFV">IFV</option>
                <option value="MBT">MBT</option>
                <option value="Artillery">Artillery</option>
                <option value="Anti-Aircraft">Anti-Aircraft</option>
              </select>
              <label for="groundUnit6">Current Unit: {{ carrierGroup.groundUnit6 }}</label>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
              <button type="submit" class="btn btn-success">Edit Carrier Group</button>
            </div>
          </div>
        </div>
      </div>
    </form>
  </body>

</template>


<script>
import { navyUnitsService } from "../services/NavyUnitsService";
import Pop from "../utils/Pop";
import { computed } from "@vue/reactivity";
import { Carrier } from "../models/Carrier";
import { AppState } from "../AppState";
import { ref } from "vue";
import { Modal } from "bootstrap";

export default {
  props: {
    carrierGroup: { Type: Carrier, required: true }
  },
  setup(props) {
    const editable = ref({})
    return {
      editable,
      account: computed(() => AppState.account),
      async deleteCarrierGroup() {
        try {
          await navyUnitsService.deleteCarrierGroup()
        } catch (error) {
          Pop.error(error, "Deleting Carrier Group")
        }
      },
      async editCarrierGroup() {
        try {
          const formData = editable.value
          Modal.getOrCreateInstance(document.getElementById(`editCarrierGroup${props.carrierGroup.id}`)).hide()
          await navyUnitsService.editCarrierGroup(formData, props.carrierGroup.id, props.carrierGroup.ownerId)
        } catch (error) {
          Pop.error(error, "Editing Carrier Group")
        }
      },
      async deleteCarrierGroup() {
        try {
          if (await Pop.confirm("Delete Carrier Group?"))
            await navyUnitsService.deleteCarrierGroup(props.carrierGroup.id)
        } catch (error) {
          Pop.error(error, "Deleting Carrier")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>
.carrier-card {
  min-width: 38vh;
  max-width: 38vh;
}

.select {
  cursor: pointer;
  color: #c10000;
}

.bg-tan {
  background: linear-gradient(#FFDA96, #dda15e);
}

.l-spacing {
  letter-spacing: 1px;
  color: black;
  text-shadow: white 2px 2px 2px;
}

.no-shadow {
  box-shadow: none;
  text-shadow: white 1px 1px;
}
</style>