<template>
  <form @submit.prevent="formDivision()">
    <div class="form-floating mb-3">
      <input v-model="editable.divisionNumber" required type="number" maxlength="2" min="1" max="6" class="form-control"
        id="divisionNumber" placeholder="1,2,3..." autocomplete="off">
      <label for="divisionNumber">Division Number(1-6)</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot1" required class="form-select" id="unitSlot1"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
      </select>
      <label for="unitSlot1">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot2" required class="form-select" id="unitSlot2"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
      </select>
      <label for="unitSlot2">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot3" required class="form-select" id="unitSlot3"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
      </select>
      <label for="unitSlot3">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot4" required class="form-select" id="unitSlot4"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
      </select>
      <label for="unitSlot4">Select Unit Type</label>
    </div>
    <div class="form-floating">
      <select v-model="editable.unitSlot5" required class="form-select" id="unitSlot5"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
      </select>
      <label for="unitSlot5">Select Unit Type</label>
    </div>
    <div class="form-floating my-3">
      <select v-model="editable.unitSlot6" required class="form-select" id="unitSlot6"
        aria-label="Select Unit for Slot">
        <option value="EmptySlot">EmptySlot</option>
        <option v-if="account.infantry >= 1" value="Infantry">Infantry ( {{ account.infantry }} )</option>
        <option v-if="account.specialForces >= 1" value="Special Forces">Special Forces ( {{ account.specialForces }} )
        </option>
        <option v-if="account.mech >= 1" value="Mech">Mech ( {{ account.mech }} )</option>
        <option v-if="account.ifv >= 1" value="IFV">IFV ( {{ account.ifv }} )</option>
        <option v-if="account.mbt >= 1" value="MBT">MBT ( {{ account.mbt }} )</option>
        <option v-if="account.artillery >= 1" value="Artillery">Artillery ( {{ account.artillery }} )</option>
        <option v-if="account.antiAircraft >= 1" value="Anti-Aircraft">Anti-Aircraft ( {{ account.antiAircraft }} )
        </option>
        <option v-if="account.ssArtillery >= 1" value="SSArtillery">Missile Artillery ( {{ account.ssArtillery }} )
        </option>
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
import { computed } from "@vue/reactivity";
import { ref } from "vue";
import Pop from "../utils/Pop";
import { armiesDivisionsService } from "../services/ArmiesDivisionsService";
import { Modal } from "bootstrap";
import { AppState } from "../AppState";
export default {
  setup() {
    const editable = ref({})

    return {
      editable,

      account: computed(() => AppState.account),

      async formDivision() {
        try {
          const formData = editable.value
          await armiesDivisionsService.formDivision(formData)
          Modal.getOrCreateInstance('#formDivision').hide()
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