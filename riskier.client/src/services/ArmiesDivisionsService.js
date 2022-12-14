import { AppState } from "../AppState"
import { Army } from "../models/Army"
import { Division } from "../models/Division"
import Pop from "../utils/Pop"
import { api } from "./AxiosService"

class ArmiesDivisionsService {

  async formDivision(formData) {
    const res = await api.post('api/armiesDivisions/division', formData)
    // console.log(res.data)
    AppState.divisions.push(new Division(res.data))
  }

  async editDivision(formData, id) {
    const res = await api.put(`api/armiesDivisions/division/${id}`, formData)
    AppState.divisions = new Division(res.data)
  }

  async getDivisionByOwnerId(ownerId) {
    const res = await api.get(`api/armiesDivisions/division/${ownerId}`)
    // console.log(res.data)
    AppState.divisions = res.data.map(d => new Division(d))
  }

  async deleteDivision(id) {
    const res = await api.delete(`api/armiesDivisions/division/${id}`)
    Pop.success("Division Deleted")
    AppState.divisions = AppState.divisions.filter(d => d.id != id)
  }

  async formArmy(formData) {
    const res = await api.post('api/armiesDivisions/army', formData)
    AppState.armies.push(new Army(res.data))
  }

  async editArmy(formData, id) {
    const res = await api.put(`api/armiesDivisions/army/${id}`, formData)
    AppState.armies = new Army(res.data)
  }

  async getArmyByOwnerId(ownerId) {
    const res = await api.get(`api/armiesDivisions/army/${ownerId}`)
    AppState.armies = res.data.map(a => new Army(a))
  }

  async deleteArmy(id) {
    const res = await api.delete(`api/armiesDivisions/army/${id}`)
    Pop.success("Army Deleted")
    AppState.armies = AppState.armies.filter(a => a.id != id)
  }

}
export const armiesDivisionsService = new ArmiesDivisionsService()