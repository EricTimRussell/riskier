<template>

  <body>
    <div class="navbar-expand-lg navbar-dark bg-dark px-3 container-fluid">
      <div class="row">
        <div class=" d-flex col-md-2 order-1">
          <div>
            <Login class="navbar-collapse mr" id="navbarText" />
          </div>
          <div>
            <button type="submit" class="btn btn-primary my-2" data-bs-toggle="modal" data-bs-target="#createRegion"
              aria-label="Create Region">
              Create Region
            </button>
          </div>
        </div>
        <div class="col-12 d-flex justify-content-center text-center order-3">
          <h2>Capital: {{ account.totalCapital }}</h2>
          <h2 class="px-3">Industry: {{ account.totalIndustry }}</h2>
          <h2>Agriculture: {{ account.totalAgriculture }}</h2>
        </div>
        <div class="col-md-8 col-sm-2 text-center order-2">
          <div class="dropdown-center dropdown"><span class="dropdown-toggle fs-2" type="button"
              data-bs-toggle="dropdown" aria-expanded="false">
              {{ account.teamName }}</span>
            <ul class="dropdown-menu">
              <li>
                <div class="input-group p-2">
                  <form class="d-flex" @submit.prevent="changeTeamName()">
                    <input type="text" class="form-control" placeholder="Change Name" aria-label="Team Name"
                      aria-describedby="button-addon2" v-model="editable.teamName">
                    <button class="btn btn-outline-secondary" type="submit" id="button-addon2">+</button>
                  </form>
                </div>
              </li>
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
.mr {
  margin-right: 3rem;
}
</style>
