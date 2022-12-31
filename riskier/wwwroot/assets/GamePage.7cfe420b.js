import{_ as F,d as N,e as l,R as M,N as O,I as j,M as T,f as U,S as G,g as P,h as V,B as L,i as Y,D as q,j as E,c as e,a as s,k as r,l as g,F as h,r as v,A as _,m as z,o,n as p,u as H,p as J,P as u,q as A,s as K,v as Q,w as n}from"./index.59488320.js";const W={setup(){const a=H();async function m(){try{await J.getRegionsByOwnerId(a.params.id)}catch(d){u.error(d,"getting regions by ownerId")}}async function y(){try{await A.getDivisionByOwnerId(a.params.id)}catch(d){u.error(d,"Getting Divisions by ownerId")}}async function i(){try{await A.getArmyByOwnerId(a.params.id)}catch(d){u.error(d,"Getting Armies by ownerId")}}return N(()=>{m(),y(),i()}),{regions:l(()=>_.regions),account:l(()=>_.account),divisions:l(()=>_.divisions),armies:l(()=>_.armies)}},components:{RegionCard:M,Navbar:O,InfantryCard:j,MechInfantryCard:T,MbtAndArtCard:U,SsArtilleryAndAntiAircraft:G,SupplyTruckCard:P,AirUnitsCard:V,BuildingsCard:L,NavyUnitsCard:Y,DivisionsCard:q,ArmyCard:E}},t=a=>(K("data-v-84a7c803"),a=a(),Q(),a),X={class:"container-fluid"},Z={class:"row"},$=t(()=>s("div",{class:"col-12 my-3 text-center bg-green py-3 elevation-5"},[s("h2",null,"Ground Forces")],-1)),ss=t(()=>s("div",{class:"col-6 pl-65"},[s("h6",null,"Infantry")],-1)),ts=t(()=>s("div",{class:"col-6 px-4"},[s("h6",null,"Special Forces")],-1)),os={class:"px-4"},es=t(()=>s("div",{class:"col-6 pl-7 pt-4"},[s("h6",null,"Mech")],-1)),ns=t(()=>s("div",{class:"col-6 pt-4 pl-65"},[s("h6",null,"IFV")],-1)),is={class:"px-4"},as=t(()=>s("div",{class:"col-6 pl-7 pt-4"},[s("h6",null,"MBT")],-1)),cs=t(()=>s("div",{class:"col-6 pt-4 pl-55"},[s("h6",null,"Artillery")],-1)),rs={class:"px-4"},ds=t(()=>s("div",{class:"col-6 pl-6 pt-4"},[s("h6",null,"SsArtillery")],-1)),ls=t(()=>s("div",{class:"col-6 pt-4 pl-5"},[s("h6",null,"AntiAircraft")],-1)),_s={class:"px-4"},hs=t(()=>s("div",{class:"col-6 pt-4 pl-6"},[s("h6",null,"SupplyTruck")],-1)),vs={class:"px-4"},ps={class:"row"},us=t(()=>s("div",{class:"col-12 mt-4 text-center bg-green elevation-5"},[s("h2",{class:"m-3"},"AirForce")],-1)),ms=t(()=>s("div",{class:"col-6 pt-3 pl-65"},[s("h6",null,"Fighter")],-1)),ys=t(()=>s("div",{class:"col-6 pt-3 pl-65"},[s("h6",null,"CAS")],-1)),gs={class:"px-4"},As={class:"row"},Cs=t(()=>s("div",{class:"col-12 mt-4 text-center bg-green elevation-5"},[s("h2",{class:"m-3"},"Navy")],-1)),fs=t(()=>s("div",{class:"col-6 pt-3 pl-7"},[s("h6",null,"Carrier")],-1)),xs=t(()=>s("div",{class:"col-6 pt-3 pl-55"},[s("h6",null,"Cruiser")],-1)),bs={class:"px-4"},ws={class:"row"},Is=t(()=>s("div",{class:"col-12 text-center mt-4 bg-green elevation-5"},[s("h2",{class:"m-3"},"Buildings")],-1)),ks=t(()=>s("div",{class:"col-6 pt-3 pl-7"},[s("h6",null,"Airfield")],-1)),Ss=t(()=>s("div",{class:"col-6 pt-3 pl-5"},[s("h6",null,"Naval Yard")],-1)),Bs={class:"px-4"},Ds={class:"container-fluid"},Rs={class:"row"},Fs={key:0,class:"col-12 d-flex flex-column align-items-center bg-green mt-4 elevation-5"},Ns=t(()=>s("h2",null,"Armies & Divisions",-1)),Ms=t(()=>s("div",null,[s("button",{class:"mx-3 p-2 rounded text-shadow-dark","data-bs-toggle":"modal","data-bs-target":"#formDivision","aria-label":"Form Division"},"Form Division"),s("button",{class:"mx-3 py-2 px-3 my-3 rounded text-shadow-dark","data-bs-toggle":"modal","data-bs-target":"#formArmy","aria-label":"Form Army"},"Form Army")],-1)),Os=[Ns,Ms],js={class:"row justify-content-center"},Ts={class:"col-6 col-md-4 my-3"},Us={key:0,class:"row justify-content-center"},Gs={class:"col-6 col-md-4 my-3"},Ps={key:1,class:"text-center pt-3"},Vs=t(()=>s("h6",null,"You currently have no armies or divisions.",-1)),Ls=[Vs],Ys={key:0,class:"container-fluid"},qs=z('<div class="row justify-content-center bg-green elevation-5 mt-5" data-v-84a7c803><div class="col-12" data-v-84a7c803><h2 class="text-center m-3" data-v-84a7c803>Owned Regions</h2></div><div class="col-12 d-flex justify-content-center mb-3" data-v-84a7c803><button type="submit" class="rounded pad text-shadow-dark p-2" data-bs-toggle="modal" data-bs-target="#createRegion" aria-label="Create Region" data-v-84a7c803> Claim Region </button></div></div>',1),Es={class:"row"},zs={class:"col-6 col-md-4 d-flex justify-content-evenly my-3"},Hs={key:1,class:"text-center pt-3"},Js=t(()=>s("h6",null,'Press "Claim Region" to add regions to your owned regions.',-1)),Ks=[Js];function Qs(a,m,y,i,d,Ws){const C=n("InfantryCard"),f=n("MechInfantryCard"),x=n("MbtAndArtCard"),b=n("SsArtilleryAndAntiAircraft"),w=n("SupplyTruckCard"),I=n("AirUnitsCard"),k=n("NavyUnitsCard"),S=n("BuildingsCard"),B=n("DivisionsCard"),D=n("ArmyCard"),R=n("RegionCard");return o(),e("body",null,[s("div",X,[s("div",Z,[$,ss,ts,s("div",os,[r(C)]),es,ns,s("div",is,[r(f)]),as,cs,s("div",rs,[r(x)]),ds,ls,s("div",_s,[r(b)]),hs,s("div",vs,[r(w)])]),s("div",ps,[us,ms,ys,s("div",gs,[r(I)])]),s("div",As,[Cs,fs,xs,s("div",bs,[r(k)])]),s("div",ws,[Is,ks,Ss,s("div",Bs,[r(S)])])]),s("div",Ds,[s("div",Rs,[i.account.id?(o(),e("div",Fs,Os)):g("",!0)]),s("div",js,[(o(!0),e(h,null,v(i.divisions,c=>(o(),e("div",Ts,[(o(),p(B,{divisions:c,key:c.id},null,8,["divisions"]))]))),256))]),i.armies.length>0||i.divisions.length>0?(o(),e("div",Us,[(o(!0),e(h,null,v(i.armies,c=>(o(),e("div",Gs,[(o(),p(D,{armies:c,key:c.id},null,8,["armies"]))]))),256))])):(o(),e("div",Ps,Ls))]),i.account.id?(o(),e("div",Ys,[qs,s("div",Es,[i.regions.length>0?(o(!0),e(h,{key:0},v(i.regions,c=>(o(),e("div",zs,[(o(),p(R,{regions:c,key:c.id},null,8,["regions"]))]))),256)):(o(),e("div",Hs,Ks))])])):g("",!0)])}const Zs=F(W,[["render",Qs],["__scopeId","data-v-84a7c803"]]);export{Zs as default};