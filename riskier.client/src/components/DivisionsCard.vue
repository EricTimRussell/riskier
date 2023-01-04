<template>

  <body>

    <div class="bg-tan l-spacing elevation-5 rounded p-1" v-if="divisions.ownerId == account.id">
      <div class="text-center">
        <h2>Division {{ divisions.divisionNumber }}</h2>
      </div>
      <div>
        <div class="text-center">
          <h6>{{ divisions.unitSlot1 }}</h6>
          <h6>{{ divisions.unitSlot2 }}</h6>
          <h6>{{ divisions.unitSlot3 }}</h6>
          <h6>{{ divisions.unitSlot4 }}</h6>
          <h6>{{ divisions.unitSlot5 }}</h6>
          <h6>{{ divisions.unitSlot6 }}</h6>
        </div>
      </div>
      <div class="d-flex justify-content-between">
        <button data-bs-toggle="modal" :data-bs-target="`#editDivision${divisions.id}`" aria-label="Edit Division"
          class="btn no-shadow mdi mdi-cog fs-2"></button>
        <button @click="deleteDivision()" class=" btn mdi mdi-delete-forever fs-2 select no-shadow"
          title="Delete?"></button>
      </div>
    </div>


    <form @submit.prevent="editDivision()">
      <div class="modal fade text-dark l-spacing" :id="`editDivision${divisions.id}`" tabindex="-1"
        aria-labelledby="editDivision" aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h1 class="modal-title fs-5">Edit Division {{ divisions.divisionNumber }}</h1>
              <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
                title="close modal"></button>
            </div>
            <div class="modal-body">
              <h6 class="text-center">*Make a selection for all fields</h6>
              <div class="form-floating">
                <select v-model="editable.unitSlot1" required class="form-select" id="unitSlot1"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot1">Current Unit: {{ divisions.unitSlot1 }}</label>
              </div>
              <div class="form-floating my-3">
                <select v-model="editable.unitSlot2" required class="form-select" id="unitSlot2"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot2">Current Unit: {{ divisions.unitSlot2 }}</label>
              </div>
              <div class="form-floating">
                <select v-model="editable.unitSlot3" required class="form-select" id="unitSlot3"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot3">Current Unit: {{ divisions.unitSlot3 }}</label>
              </div>
              <div class="form-floating my-3">
                <select v-model="editable.unitSlot4" required class="form-select" id="unitSlot4"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot4">Current Unit: {{ divisions.unitSlot4 }}</label>
              </div>
              <div class="form-floating">
                <select v-model="editable.unitSlot5" required class="form-select" id="unitSlot5"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot5">Current Unit: {{ divisions.unitSlot5 }}</label>
              </div>
              <div class="form-floating my-3">
                <select v-model="editable.unitSlot6" required class="form-select" id="unitSlot6"
                  aria-label="Select Unit for Slot">
                  <option value="EmptySlot">EmptySlot</option>
                  <option value="Infantry">Infantry</option>
                  <option value="Special Forces">Special Forces</option>
                  <option value="Mech">Mech</option>
                  <option value="IFV">IFV</option>
                  <option value="MBT">MBT</option>
                  <option value="Artillery">Artillery</option>
                  <option value="Anti-Aircraft">Anti-Aircraft</option>
                </select>
                <label for="unitSlot6">Current Unit: {{ divisions.unitSlot6 }}</label>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
                <button type="submit" class="btn btn-success">Edit Division</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </form>
  </body>


</template>


<script>
import { Division } from "../models/Division";
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import CreateDivisionForm from "./CreateDivisionForm.vue";
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
import { ref, watchEffect } from "vue";
import Pop from "../utils/Pop";
import { Modal } from "bootstrap";

export default {
  props: {
    divisions: { Type: Division, required: true }
  },
  setup(props) {
    const editable = ref({})
    watchEffect(() => {
      editable.value = { ...AppState.divisions }
    })
    return {
      editable,
      async editDivision() {
        try {
          Modal.getOrCreateInstance(document.getElementById(`editDivision${props.divisions.id}`)).hide()
          const formData = editable.value
          await armiesDivisionsService.editDivision(formData, props.divisions.id, props.divisions.ownerId)
        } catch (error) {
          Pop.error(error, "Editing Division")
        }
      },
      async deleteDivision() {
        try {
          if (await Pop.confirm("Delete Division?"))
            await armiesDivisionsService.deleteDivision(props.divisions.id)
        } catch (error) {
          Pop.error(error, "Deleting Division")
        }
      },
      account: computed(() => AppState.account)
    };
  },
  components: { CreateDivisionForm }
}
</script>


<style lang="scss" scoped>
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