import { accountService } from "./AccountService"
import { api } from "./AxiosService"

class AirUnitsService {

  async addFighterAircraft() {
    const res = await api.post('api/airUnits/fighterAircraft')
    accountService.getAccount()
  }

  async removeFighterAircraft() {
    const res = await api.delete('api/airUnits/fighterAircraft')
    accountService.getAccount()
  }

  async addCloseAirSupport() {
    const res = await api.post('api/airUnits/CloseAirSupport')
    accountService.getAccount()
  }

  async removeCloseAirSupport() {
    const res = await api.delete('api/airUnits/CloseAirSupport')
    accountService.getAccount()
  }

  async addTransportAircraft() {
    const res = await api.post('api/airUnits/TransportAircraft')
    accountService.getAccount()
  }

  async removeTransportAircraft() {
    const res = await api.delete('api/airUnits/TransportAircraft')
    accountService.getAccount()
  }



}
export const airUnitsService = new AirUnitsService()