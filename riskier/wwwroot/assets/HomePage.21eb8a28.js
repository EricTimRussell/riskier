import{_ as c,e as t,R as r,N as d,I as l,M as u,g as p,S as y,h,i as m,B as v,j as _,D as f,k as g,a as b,b as o,p as w,z as k,m as x,A as a,n as C,y as S,o as n,w as A,x as B}from"./index.c15ffc50.js";const I={setup(){return{regions:t(()=>a.regions),account:t(()=>a.account),divisions:t(()=>a.divisions),armies:t(()=>a.armies)}},components:{RegionCard:r,Navbar:d,InfantryCard:l,MechInfantryCard:u,MbtAndArtCard:p,SsArtilleryAndAntiAircraft:y,SupplyTruckCard:h,AirUnitsCard:m,BuildingsCard:v,NavyUnitsCard:_,DivisionsCard:f,ArmyCard:g}},N=e=>(A("data-v-46ec05c8"),e=e(),B(),e),R={class:"container-fluid"},j=C('<div class="row" data-v-46ec05c8><div class="col-12 d-flex flex-column align-items-center pt-3" data-v-46ec05c8><h1 data-v-46ec05c8>Welcome to Riskier!</h1><p class="px-3" data-v-46ec05c8>\xA0\xA0\xA0Log in or create an account to get started. You do not need to use a real email to create an account. Use your account picture in the top left to navigate the website.</p><h2 data-v-46ec05c8>Quick Setup Instructions</h2><p class="px-3" data-v-46ec05c8> Every faction starts with a capital, 2 medium cities, and 3 small cities. Once you have chosen your starting location you now own all the tiles around your capital and can choose 3 more tiles to expand too so long as they are adjacent to tiles you already own. You can now place your cities wherever you like within your controlled territory. Now press &quot;Get Started&quot; and scroll to the bottom and claim a city for each city and claim a region for each tile you own that does not have a city present. </p><p class="px-3" data-v-46ec05c8> Once your regions and cities have been claimed you now have resources to spend on units and buildings. During the setup phase all your units and building build instantly and can be placed wherever you like so long as it is within your owned territory. </p><h3 data-v-46ec05c8>Setup Tips</h3><ul class="px-3" data-v-46ec05c8><li data-v-46ec05c8>Be sure to build what buildings you want first before building units.</li><li data-v-46ec05c8>Remember that your capital city is also an airfield</li><li data-v-46ec05c8>You will have to build your units first before forming an army or division</li><li data-v-46ec05c8>When placing your starting units think about how you want to distribute them in order to capture the most regions as you can. Armies and divisions can capture unclaimed territory instantly, but are very limited in number.</li><li data-v-46ec05c8>Be sure to refer to the rule book and unit odds to better understand strengths and weaknesses of each unit type</li></ul></div></div>',1),D={class:"col-12 py-3 d-flex justify-content-center"},G=N(()=>o("button",{class:"btn"},"Get Started",-1));function M(e,U,V,i,Y,q){const s=S("router-link");return n(),b("body",null,[o("main",R,[j,o("div",D,[i.account.id?(n(),w(s,{key:0,to:{name:"Game",params:{id:i.account.id}}},{default:k(()=>[G]),_:1},8,["to"])):x("",!0)])])])}const H=c(I,[["render",M],["__scopeId","data-v-46ec05c8"]]);export{H as default};
