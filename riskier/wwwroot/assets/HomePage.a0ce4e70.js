import{_ as i,e as t,R as d,N as l,I as _,M as p,f as u,S as m,g as f,h as y,B as g,i as h,D as v,j as C,c as A,a as e,m as S,w as b,l as k,A as o,v as x,o as n,q as I,s as B}from"./index.91275b32.js";const N={setup(){return{regions:t(()=>o.regions),account:t(()=>o.account),divisions:t(()=>o.divisions),armies:t(()=>o.armies)}},components:{RegionCard:d,Navbar:l,InfantryCard:_,MechInfantryCard:p,MbtAndArtCard:u,SsArtilleryAndAntiAircraft:m,SupplyTruckCard:f,AirUnitsCard:y,BuildingsCard:g,NavyUnitsCard:h,DivisionsCard:v,ArmyCard:C}},r=a=>(I("data-v-956a3253"),a=a(),B(),a),w={class:"container-fluid"},G=r(()=>e("div",{class:"row"},[e("div",{class:"col-12 d-flex flex-column align-items-center"},[e("h1",null,"Welcome to Riskier!"),e("p",{class:"px-3"},'\xA0\xA0\xA0Log in or create an account to get started. You do not need to use a real email to create an account. Once you have logged in or created an account press "Get Started" to begin. It may be necessary to refresh the page in order for the "Get Started" button to appear.')])],-1)),M={class:"col-12 sticky-bottom py-3 d-flex justify-content-center"},R=r(()=>e("button",{class:"btn"},"Get Started",-1));function j(a,D,H,s,P,U){const c=x("router-link");return n(),A("body",null,[e("main",w,[G,e("div",M,[s.account.id?(n(),S(c,{key:0,to:{name:"Game",params:{id:s.account.id}}},{default:b(()=>[R]),_:1},8,["to"])):k("",!0)])])])}const $=i(N,[["render",j],["__scopeId","data-v-956a3253"]]);export{$ as default};
