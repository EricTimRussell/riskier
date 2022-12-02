import { AppState } from '../AppState'
import { Account } from "../models/Account"
import { logger } from '../utils/Logger'
import { api } from './AxiosService'
import { regionTilesService } from "./RegionTilesService"

class AccountService {
  async getAccount() {
    try {
      const res = await api.get('/account')
      AppState.account = new Account(res.data)
    } catch (err) {
      logger.error('HAVE YOU STARTED YOUR SERVER YET???', err)
    }
  }

  async changeTeamName(formData) {
    const res = await api.put('/account', formData)
    AppState.account = new Account(res.data)
    regionTilesService.getAllRegions()
  }
}

export const accountService = new AccountService()
