<template>
  <span class="navbar-text">
    <button class="btn selectable text-shadow lighten-30 text-uppercase my-2 my-lg-0" @click="login"
      v-if="!user.isAuthenticated">
      Login
    </button>
    <div v-else>
      <div class="dropdown dropbottom my-2 my-lg-0">

        <!-- SECTION User avatar -->
        <div type="button" class="border-0 selectable no-select" data-bs-toggle="dropdown" aria-expanded="false">
          <div v-if="account.picture || user.picture">
            <img :src="account.picture || user.picture" alt="account photo" :title="account.name" height="40"
              class="rounded" />
          </div>
        </div>

        <!-- SECTION Nav elements and user logout -->
        <div class="dropdown-menu dropdown-menu-lg-left p-0" aria-labelledby="authDropdown">
          <div class="list-group">
            <router-link :to="{ name: 'Home' }">
              <div class="list-group-item dropdown-item list-group-item-action">
                Home
              </div>
            </router-link>
            <div class="list-group-item dropdown-item list-group-item-action text-danger selectable" @click="logout">
              <i class="mdi mdi-logout"></i>
              logout
            </div>
          </div>
        </div>
      </div>
    </div>
  </span>
</template>

<script>
import { computed } from 'vue'
import { AppState } from '../AppState'
import { AuthService } from '../services/AuthService'

export default {
  setup() {
    return {
      user: computed(() => AppState.user),

      account: computed(() => AppState.account),

      async login() {
        AuthService.loginWithPopup()
      },

      async logout() {
        AuthService.logout({ returnTo: window.location.origin })
      }
    }
  }
}
</script>

<style lang="scss" scoped>
button {
  background-color: #FFDA96;
}

.text-shadow {
  color: whitesmoke;
  text-shadow: #000000 2px 2px;
  letter-spacing: 1px;
}
</style>
