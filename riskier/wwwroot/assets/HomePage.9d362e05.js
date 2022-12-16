import{_ as S,d,R as I,N as w,I as B,M as F,e as M,S as N,f as D,g as R,B as U,h as j,D as T,i as V,c,a as s,j as i,F as _,r as p,k as G,A as r,o,l as h,p as H,m as L,n}from"./index.b343f835.js";const P={setup(){return{regions:d(()=>r.regions),account:d(()=>r.account),divisions:d(()=>r.divisions),armies:d(()=>r.armies)}},components:{RegionCard:I,Navbar:w,InfantryCard:B,MechInfantryCard:F,MbtAndArtCard:M,SsArtilleryAndAntiAircraft:N,SupplyTruckCard:D,AirUnitsCard:R,BuildingsCard:U,NavyUnitsCard:j,DivisionsCard:T,ArmyCard:V}},t=a=>(H("data-v-03a10fcb"),a=a(),L(),a),E={key:0,class:"container-fluid"},O={class:"row"},Y=t(()=>s("div",{class:"col-12 mb-3 text-center"},[s("h2",null,"Ground Forces")],-1)),q=t(()=>s("div",{class:"col-6 pl-65"},[s("h6",null,"Infantry")],-1)),z=t(()=>s("div",{class:"col-6 px-4"},[s("h6",null,"Special Forces")],-1)),J={class:"px-4"},K=t(()=>s("div",{class:"col-6 pl-7 pt-4"},[s("h6",null,"Mech")],-1)),Q=t(()=>s("div",{class:"col-6 pt-4 pl-65"},[s("h6",null,"IFV")],-1)),W={class:"px-4"},X=t(()=>s("div",{class:"col-6 pl-7 pt-4"},[s("h6",null,"MBT")],-1)),Z=t(()=>s("div",{class:"col-6 pt-4 pl-55"},[s("h6",null,"Artillery")],-1)),$={class:"px-4"},ss=t(()=>s("div",{class:"col-6 pl-6 pt-4"},[s("h6",null,"SsArtillery")],-1)),ts=t(()=>s("div",{class:"col-6 pt-4 pl-5"},[s("h6",null,"AntiAircraft")],-1)),os={class:"px-4"},ns=t(()=>s("div",{class:"col-6 pt-4 pl-6"},[s("h6",null,"SupplyTruck")],-1)),cs={class:"px-4"},es={class:"row"},is=t(()=>s("div",{class:"col-12 mt-4 text-center bg-green"},[s("h2",{class:"m-3"},"AirForce")],-1)),ls=t(()=>s("div",{class:"col-6 pt-3 pl-65"},[s("h6",null,"Fighter")],-1)),as=t(()=>s("div",{class:"col-6 pt-3 pl-65"},[s("h6",null,"CAS")],-1)),ds={class:"px-4"},rs={class:"row"},_s=t(()=>s("div",{class:"col-12 mt-4 text-center bg-green"},[s("h2",{class:"m-3"},"Navy")],-1)),ps=t(()=>s("div",{class:"col-6 pt-3 pl-7"},[s("h6",null,"Carrier")],-1)),hs=t(()=>s("div",{class:"col-6 pt-3 pl-55"},[s("h6",null,"Cruiser")],-1)),vs={class:"px-4"},us={class:"row"},ms=t(()=>s("div",{class:"col-12 text-center mt-4 bg-green"},[s("h2",{class:"m-3"},"Buildings")],-1)),ys=t(()=>s("div",{class:"col-6 pt-3 pl-7"},[s("h6",null,"Airfield")],-1)),gs=t(()=>s("div",{class:"col-6 pt-3 pl-5"},[s("h6",null,"Naval Yard")],-1)),fs={class:"px-4"},As={key:1,class:"container-fluid"},Cs=t(()=>s("div",{class:"row"},[s("div",{class:"col-12 text-center"},[s("h1",null,"Select Login to Get Started")])],-1)),xs=[Cs],bs={class:"container-fluid"},ks=t(()=>s("div",{class:"row"},[s("div",{class:"col-12 d-flex flex-column align-items-center bg-green gap-2 mt-4"},[s("h2",null,"Armies & Divisions"),s("div",null,[s("button",{class:"mx-3 p-2 rounded","data-bs-toggle":"modal","data-bs-target":"#formDivision","aria-label":"Form Division"},"Form Division"),s("button",{class:"mx-3 py-2 px-3 my-3 rounded","data-bs-toggle":"modal","data-bs-target":"#formArmy","aria-label":"Form Army"},"Form Army")])])],-1)),Ss={class:"row justify-content-center"},Is={class:"col-10 col-md-6 my-2"},ws={class:"row justify-content-center"},Bs={class:"col-10 col-md-6 my-2"},Fs={key:2,class:"container-fluid"},Ms=t(()=>s("div",{class:"row justify-content-center mt-5"},[s("div",{class:"col-12 bg-green"},[s("h2",{class:"text-center m-3"},"Owned Regions")])],-1)),Ns={class:"row"},Ds={class:"col-6 col-md-3 d-flex justify-content-evenly my-2"},Rs=t(()=>s("footer",{class:"sticky-bottom text-end px-3"},[s("i",{class:"mdi mdi-book-open-variant fs-1 text-light selectable",title:"Rule Book","data-bs-toggle":"modal","data-bs-target":"#rulesModal"})],-1));function Us(a,js,Ts,l,Vs,Gs){const v=n("InfantryCard"),u=n("MechInfantryCard"),m=n("MbtAndArtCard"),y=n("SsArtilleryAndAntiAircraft"),g=n("SupplyTruckCard"),f=n("AirUnitsCard"),A=n("NavyUnitsCard"),C=n("BuildingsCard"),x=n("DivisionsCard"),b=n("ArmyCard"),k=n("RegionCard");return o(),c("body",null,[l.account.id?(o(),c("div",E,[s("div",O,[Y,q,z,s("div",J,[i(v)]),K,Q,s("div",W,[i(u)]),X,Z,s("div",$,[i(m)]),ss,ts,s("div",os,[i(y)]),ns,s("div",cs,[i(g)])]),s("div",es,[is,ls,as,s("div",ds,[i(f)])]),s("div",rs,[_s,ps,hs,s("div",vs,[i(A)])]),s("div",us,[ms,ys,gs,s("div",fs,[i(C)])])])):(o(),c("div",As,xs)),s("div",bs,[ks,s("div",Ss,[(o(!0),c(_,null,p(l.divisions,e=>(o(),c("div",Is,[(o(),h(x,{divisions:e,key:e.id},null,8,["divisions"]))]))),256))]),s("div",ws,[(o(!0),c(_,null,p(l.armies,e=>(o(),c("div",Bs,[(o(),h(b,{armies:e,key:e.id},null,8,["armies"]))]))),256))])]),l.account.id?(o(),c("div",Fs,[Ms,s("div",Ns,[(o(!0),c(_,null,p(l.regions,e=>(o(),c("div",Ds,[(o(),h(k,{regions:e,key:e.id},null,8,["regions"]))]))),256))])])):G("",!0),Rs])}const Ls=S(P,[["render",Us],["__scopeId","data-v-03a10fcb"]]);export{Ls as default};