import { AppState } from "../AppState"
import { accountService } from "./AccountService";
import { api } from "./AxiosService"

class LandUnitsService {

  async addInfantry() {
    const res = await api.post('api/landUnits/infantry')
    accountService.getAccount()
  }

  async removeInfantry() {
    const res = await api.delete('api/landUnits/infantry')
    accountService.getAccount()
  }

  async addSpecialForces() {
    const res = await api.post('api/landUnits/specialForces')
    accountService.getAccount()
  }

  async removeSpecialForces() {
    const res = await api.delete('api/landUnits/specialForces')
    accountService.getAccount()
  }

  // Mech = Mechanized Infantry
  async addMech() {
    const res = await api.post('api/landunits/mech')
    accountService.getAccount()
  }

  async removeMech() {
    const res = await api.delete('api/landUnits/mech')
    accountService.getAccount()
  }

  // IFV = Infantry Fighting Vehicle
  async addIfv() {
    const res = await api.post('api/landunits/ifv')
    accountService.getAccount()
  }

  async removeIfv() {
    const res = await api.delete('api/landUnits/ifv')
    accountService.getAccount()
  }

  // MBT = Main Battle Tank
  async addMbt() {
    const res = await api.post('api/landunits/mbt')
    accountService.getAccount()
  }

  async removeMbt() {
    const res = await api.delete('api/landUnits/mbt')
    accountService.getAccount()
  }

  async addArtillery() {
    const res = await api.post('api/landunits/artillery')
    accountService.getAccount()
  }

  async removeArtillery() {
    const res = await api.delete('api/landUnits/artillery')
    accountService.getAccount()
  }

  // SsArtillery also known as missile artillery on board game
  async addSsArtillery() {
    const res = await api.post('api/landunits/ssArtillery')
    accountService.getAccount()
  }

  async removeSsArtillery() {
    const res = await api.delete('api/landUnits/ssArtillery')
    accountService.getAccount()
  }

  async addAntiAircraft() {
    const res = await api.post('api/landunits/antiAircraft')
    accountService.getAccount()
  }

  async removeAntiAircraft() {
    const res = await api.delete('api/landUnits/antiAircraft')
    accountService.getAccount()
  }

  async addSupplyTruck() {
    const res = await api.post('api/landunits/supplyTruck')
    accountService.getAccount()
  }

  async removeSupplyTruck() {
    const res = await api.delete('api/landUnits/supplyTruck')
    accountService.getAccount()
  }
}
export const landUnitsService = new LandUnitsService()