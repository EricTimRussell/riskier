<template>

  <body>
    <div class="navbar-expand-lg navbar-dark bg-green px-3 container-fluid border-b elevation-5">
      <div class="row">
        <div class=" d-flex col-md-6 col-sm-8 col-12 order-1 vh">
          <div>
            <Login class="navbar-collapse mr" id="navbarText" />
          </div>
          <div v-if="account.id" class="my-2">
            <button type="submit" class="rounded pad" data-bs-toggle="modal" data-bs-target="#createRegion"
              aria-label="Create Region">
              Claim Region
            </button>
            <button class="mdi mdi-dice-multiple-outline fs-3 mx-4 rounded" data-bs-toggle="modal"
              data-bs-target="#unitOdds" aria-label="Unit Odds" title="Unit Odds"></button>
            <button class="mdi mdi-currency-usd fs-3 rounded" data-bs-toggle="modal" data-bs-target="#unitCost"
              aria-label="Unit Cost" title="Unit Cost"></button>
          </div>
        </div>
        <div class="col-12 d-flex justify-content-center text-center order-3 text-shadow" v-if="account.id">
          <div>
            <h2 v-if="account.totalCapital >= 0">Capital {{ account.totalCapital }}</h2>
            <h2 v-else="account.totalCapital <= -1" class="text-danger">Capital {{ account.totalCapital }}</h2>
          </div>
          <div>
            <h2 v-if="account.totalIndustry >= 0" class="px-2">Industry {{ account.totalIndustry }}</h2>
            <h2 v-else="account.totalIndustry <= -1" class="px-2 text-danger">Industry {{ account.totalIndustry }}</h2>
          </div>
          <div>
            <h2 v-if="account.totalAgriculture >= 0">Agriculture {{ account.totalAgriculture }}</h2>
            <h2 v-else="account.totalAgriculture <=-1" class="text-danger">Agriculture {{ account.totalAgriculture }}
            </h2>
          </div>
        </div>
        <div class="col-md-6 col-sm-4 text-center order-2" v-if="account.id">
          <div class="dropdown-center dropdown text-shadow mt-3"><span class="dropdown-toggle fs-2" type="button"
              data-bs-toggle="dropdown" aria-expanded="false">
              {{ account.teamName }}</span>
            <ul class="dropdown-menu">
              <div class="input-group p-2">
                <form class="d-flex" @submit.prevent="changeTeamName()">
                  <input type="text" class="form-control" placeholder="Change Name" maxlength="18"
                    aria-label="Team Name" aria-describedby="button-addon2" v-model="editable.teamName">
                  <button class="btn btn-outline-secondary" type="submit" id="button-addon2">+</button>
                </form>
              </div>
            </ul>
          </div>
        </div>
      </div>
    </div>

  </body>



</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { accountService } from "../services/AccountService";
import Pop from "../utils/Pop";
import { ref } from "vue";
import Login from './Login.vue'
export default {
  setup() {
    const editable = ref({})
    return {
      editable,
      account: computed(() => AppState.account),

      async changeTeamName() {
        try {
          const formData = editable.value
          await accountService.changeTeamName(formData)
          editable.value = {}
        } catch (error) {
          Pop.error(error, "Changing Team Name")
        }
      }
    }
  },
  components: { Login }
}
</script>

<style scoped>
.text-shadow {
  color: whitesmoke;
  text-shadow: #000000 2px 2px;
  letter-spacing: 1px;
}

button {
  background-color: #FFDA96;
}

.border-b {
  border-bottom: 3px solid black;
}

.mr {
  margin-right: 5rem;
}

.bg-green {
  background-color: #606C38;
}

.vh {
  max-height: 8vh;
}

.pad {
  padding-top: .55rem;
  padding-bottom: .3rem;
}
</style>
