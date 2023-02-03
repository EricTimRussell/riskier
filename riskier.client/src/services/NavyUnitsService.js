import { AppState } from "../AppState"
import { Carrier } from "../models/Carrier"
import { accountService } from "./AccountService"
import { api } from "./AxiosService"

class NavyUnitsService {

  async formCarrierGroup(formData) {
    const res = await api.post('api/navyUnits/carrierGroup', formData)
    // console.log(res.data);
    AppState.carrierGroups.push(new Carrier(res.data))
  }

  async editCarrierGroup(formData, id, ownerId) {
    const res = await api.put(`api/navyUnits/carrierGroup/${id}`, formData)
    AppState.carrierGroups = new Carrier(res.data)
    this.getCarrierGroupByOwnerId(ownerId)
  }

  async deleteCarrierGroup(id) {
    const res = await api.delete(`api/navyUnits/carrierGroup/${id}`)
    AppState.carrierGroups = AppState.carrierGroups.filter(c => c.id != id)
  }

  async getCarrierGroupByOwnerId(ownerId) {
    const res = await api.get('api/navyUnits/carrierGroup/' + ownerId)
    AppState.carrierGroups = res.data.map(c => new Carrier(c))

  }

  // Carrier = Aircraft Carrier
  async addCarrier() {
    const res = await api.post('api/navyUnits/carrier')
    accountService.getAccount()
  }

  async removeCarrier() {
    const res = await api.delete('api/navyUnits/carrier')
    accountService.getAccount()
  }
  async addCruiser() {
    const res = await api.post('api/navyUnits/cruiser')
    accountService.getAccount()
  }

  async removeCruiser() {
    const res = await api.delete('api/navyUnits/cruiser')
    accountService.getAccount()
  }
  async addDestroyer() {
    const res = await api.post('api/navyUnits/destroyer')
    accountService.getAccount()
  }

  async removeDestroyer() {
    const res = await api.delete('api/navyUnits/destroyer')
    accountService.getAccount()
  }
}
export const navyUnitsService = new NavyUnitsService()