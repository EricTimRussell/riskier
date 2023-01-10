<template>

  <body>

    <div class="bg-tan l-spacing elevation-5 rounded p-1" v-if="armies.ownerId == account.id">
      <div class="text-center">
        <h2>Army {{ armies.armyNumber }}</h2>
      </div>
      <div>
        <div class="text-center">
          <h6>{{ armies.unitSlot1 }}</h6>
          <h6>{{ armies.unitSlot2 }}</h6>
          <h6>{{ armies.unitSlot3 }}</h6>
          <h6>{{ armies.unitSlot4 }}</h6>
          <h6>{{ armies.unitSlot5 }}</h6>
          <h6>{{ armies.unitSlot6 }}</h6>
          <h6>{{ armies.unitSlot7 }}</h6>
          <h6>{{ armies.unitSlot8 }}</h6>
          <h6>{{ armies.unitSlot9 }}</h6>
        </div>
      </div>
      <div class="d-flex justify-content-between">
        <button data-bs-toggle="modal" :data-bs-target="`#editArmy${armies.id}`" aria-label="Edit Army"
          class="btn no-shadow mdi mdi-cog fs-2"></button>
        <button @click="deleteArmy()" class=" btn mdi mdi-delete-forever fs-2 select no-shadow"
          title="Delete?"></button>
      </div>
    </div>


    <form @submit.prevent="editArmy()">
      <div class="modal fade text-dark l-spacing" :id="`editArmy${armies.id}`" tabindex="-1" aria-labelledby="editArmy"
        aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h1 class="modal-title fs-5">Edit Army {{ armies.armyNumber }}</h1>
              <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
                title="close modal"></button>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot1" class="form-select" required id="unitSlot1"
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
              <label for="unitSlot1">Selected Unit</label>
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
              <label for="unitSlot2">Selected Unit</label>
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
              <label for="unitSlot3">Selected Unit</label>
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
              <label for="unitSlot4">Selected Unit</label>
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
              <label for="unitSlot5">Selected Unit</label>
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
              <label for="unitSlot6">Selected Unit</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot7" required class="form-select" id="unitSlot7"
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
              <label for="unitSlot7">Selected Unit</label>
            </div>
            <div class="form-floating my-3">
              <select v-model="editable.unitSlot8" required class="form-select" id="unitSlot8"
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
              <label for="unitSlot8">Selected Unit</label>
            </div>
            <div class="form-floating">
              <select v-model="editable.unitSlot9" required class="form-select" id="unitSlot9"
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
              <label for="unitSlot9">Selected Unit</label>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
              <button type="submit" class="btn btn-success">Edit Army</button>
            </div>
          </div>
        </div>
      </div>
    </form>
  </body>


</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
import { ref } from "vue";
import Pop from "../utils/Pop";
import { Modal } from "bootstrap";
import { Army } from "../models/Army";

export default {
  props: {
    armies: { Type: Army, required: true }
  },
  setup(props) {
    const editable = ref({ unitSlot1: `${props.armies.unitSlot1}`, unitSlot2: `${props.armies.unitSlot2}`, unitSlot3: `${props.armies.unitSlot3}`, unitSlot4: `${props.armies.unitSlot4}`, unitSlot5: `${props.armies.unitSlot5}`, unitSlot6: `${props.armies.unitSlot6}`, unitSlot7: `${props.armies.unitSlot7}`, unitSlot8: `${props.armies.unitSlot8}`, unitSlot9: `${props.armies.unitSlot9}` })
    return {
      editable,
      async editArmy() {
        try {
          Modal.getOrCreateInstance(document.getElementById(`editArmy${props.armies.id}`)).hide()
          await armiesDivisionsService.editArmy(editable.value, props.armies.id, props.armies.ownerId)
        } catch (error) {
          Pop.error(error, "Editing army")
        }
      },
      async deleteArmy() {
        try {
          if (await Pop.confirm("Delete Army?"))
            await armiesDivisionsService.deleteArmy(props.armies.id)
        } catch (error) {
          Pop.error(error, "Deleting army")
        }
      },
      account: computed(() => AppState.account)
    };
  },
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