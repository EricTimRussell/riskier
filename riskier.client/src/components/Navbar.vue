<template>
  <body>
    <div class="navbar-expand-lg navbar-dark bg-green px-3 container-fluid border-b elevation-5">
      <div class="row">
        <div class=" d-flex col-12 order-1 vh justify-content-evenly mb-3">

          <!--SECTION login component and player avatar display  -->
          <div>
            <Login class="navbar-collapse" id="navbarText" />
          </div>

          <!-- SECTION unit modal section and rule book router-link -->
          <div v-if="account.id" class="my-2">
            <router-link :to="{ name: 'Rules' }">
              <button class="mdi mdi-book-open-variant fs-3 rounded text-shadow-dark" title="Rule Book"></button>
            </router-link>
            <router-link :to="{ name: 'Game', params: { id: account.id } }">
              <button class="mdi mdi-controller fs-3 mx-4 rounded text-shadow-dark"></button>
            </router-link>
            <button class="mdi mdi-dice-multiple-outline fs-3 rounded text-shadow-dark" data-bs-toggle="modal"
              data-bs-target="#unitOdds" aria-label="Unit Odds" title="Unit Odds"></button>
          </div>
        </div>

        <!-- SECTION players total resources and production display -->
        <div class="col-12 d-flex justify-content-evenly text-center order-3 text-shadow" v-if="account.id">
          <div>
            <span class="mdi mdi-currency-usd fs-3 text-warning"></span>
            <h3 v-if="account.totalCapital >= 0">{{ account.totalCapital }}</h3>
            <h3 v-else="account.totalCapital <= -1" class="text-danger">{{ account.totalCapital }}</h3>
          </div>
          <div>
            <span class="mdi mdi-factory fs-3 text-secondary"></span>
            <h3 v-if="account.totalIndustry >= 0" class="px-2">{{ account.totalIndustry }}</h3>
            <h3 v-else="account.totalIndustry <= -1" class="px-2 text-danger">{{ account.totalIndustry }}</h3>
          </div>
          <div>
            <span class="mdi mdi-barley fs-3 text-success"></span>
            <h3 v-if="account.totalAgriculture >= 0">{{ account.totalAgriculture }}</h3>
            <h3 v-else="account.totalAgriculture <=-1" class="text-danger">{{ account.totalAgriculture }}
            </h3>
          </div>
          <div>
            <span class="mdi mdi-wrench fs-3 text-dark"></span>
            <h3 v-if="account.totalProduction >= 0">{{ account.totalProduction }}</h3>
            <h3 v-else="account.totalProduction <=-1" class="text-danger">{{ account.totalProduction }}
            </h3>
          </div>
        </div>

        <!-- SECTION team name is currently disabled as it serves no purpose yet-->
        <!-- <div class="col-12 text-center order-2" v-if="account.id">
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
        </div> -->
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

      // Currently disabled serves no purpose
      // async changeTeamName() {
      //   try {
      //     const formData = editable.value
      //     await accountService.changeTeamName(formData)
      //     editable.value = {}
      //   } catch (error) {
      //     Pop.error(error, "Changing Team Name")
      //   }
      // }
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

.text-shadow-dark {
  color: #1d1d1d;
  text-shadow: whitesmoke 2px 2px;
  letter-spacing: 1px;
}

button {
  background: linear-gradient(#FFDA96, #dda15e);
}

.border-b {
  border-bottom: 3px solid black;
}

.mr {
  margin-right: 3rem;
}

.bg-green {
  background: linear-gradient(#606c38, #283618)
}

.vh {
  max-height: 8vh;
}

.pad {
  padding-top: .55rem;
  padding-bottom: .3rem;
}

button:active {
  box-shadow: none;
  background: #515151
}
</style>
