<template>
  <body>

    <main class="container-fluid">
      <h1 class="text-center pt-3">Welcome to Riskier</h1>
      <div class="accordion pt-3" id="accordion1">
        <div class="accordion-item no-bg text-light">
          <h2 class="accordion-header" id="headingOne">
            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne"
              aria-expanded="true" aria-controls="collapseOne">
              Quick Setup
            </button>
          </h2>
          <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne"
            data-bs-parent="#accordion1">
            <div class="accordion-body">
              <p class="px-3">&nbsp;&nbsp;&nbsp;Log in or create an account to get started. You do not need to use a real
                email to create an account. Use the buttons at the top of the page to navigate the website.</p>
            </div>
          </div>
        </div>
        <div class="accordion-item no-bg text-light">
          <h2 class="accordion-header" id="headingTwo">
            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
              data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
              How this app works
            </button>
          </h2>
          <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo"
            data-bs-parent="#accordion2">
            <div class="accordion-body">
              <p>This app is designed to improve a players quality of life during the game. With the app a player can
                track all of their teams assets and regions. The app will automatically update the players resources as a
                player purchases or loses units and buildings.</p>
              <p>Players can also track groups of units using the create army/division section as well as track naval
                carrier groups.</p>
              <p>Regions can be claimed by pressing the "Claim Region" button or "Claim City" button if their is a city
                present on the tile. Claim region will automatically generate a random number of resurces for that region.
                Claim city lets the player set the number of resources based on the size of the city.</p>
            </div>
          </div>
        </div>
        <div class="accordion-item no-bg text-light">
          <h2 class="accordion-header" id="headingThree">
            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
              data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
              Quick Tips
            </button>
          </h2>
          <div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree"
            data-bs-parent="#accordion3">
            <div class="accordion-body">
              <ul class="px-3">
                <li class="py-1">Be sure to build what buildings you want first before building units.</li>
                <li class="py-1">Remember that your capital city is also an airfield</li>
                <li class="py-1">You will have to build your units first before forming an army or division</li>
                <li class="py-1">When placing your starting units think about how you want to distribute them in order to
                  capture the
                  most regions as you can. Armies and divisions can capture unclaimed territory instantly, but are very
                  limited in number.</li>
                <li class="py-1">Be sure to refer to the rule book and unit odds to better understand strengths and
                  weaknesses of each
                  unit type</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
      <div class="col-12 py-3 d-flex justify-content-center">
        <router-link v-if="account.id" :to="{ name: 'Game', params: { id: account.id } }">
          <button class="btn">Get Started</button>
        </router-link>
      </div>
    </main>

  </body>
</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";

export default {
  setup() {
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account),
      divisions: computed(() => AppState.divisions),
      armies: computed(() => AppState.armies)
    };
  },
}
</script>

<style scoped lang="scss">
body {
  color: #1d1d1d;
  text-shadow: #000000 3px 3px 2px;
  color: whitesmoke;
  min-height: 80vh;
  font-size: 16px;
  font-weight: 500;
  letter-spacing: 2px;
}

button {
  background-color: #FFDA96;
}

.no-bg {
  background-color: #ffffff74;
}
</style>
