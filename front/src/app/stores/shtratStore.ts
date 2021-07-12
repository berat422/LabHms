import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import {v4 as uuid} from 'uuid';
import { IShtrat } from "../models/IShtrat";
import { ILlojiShtratit } from "../models/ILlojiShtratit";

export default class ShtratStore {
    Shtreter: IShtrat[] = [];
    selectedShtrat: IShtrat | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = false;

    constructor(){
        makeAutoObservable(this)
    }

    loadShtreter = async () => {
        this.setLoadingInitial(true);
        this.Shtreter = [];
        try{
            const Shtreter = await agent.Shtreter.list();
                Shtreter.forEach(Shtrat => {
                    this.Shtreter.push(Shtrat);
                })
                this.setLoadingInitial(false);
        } catch(error){
            console.log(error);
                this.setLoadingInitial(true);
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    selectShtrat = async(shtrat_id: string) => {
        this.selectedShtrat= await agent.Shtreter.details(shtrat_id);
    }


    cancelSelectedShtrat = () => {
        this.selectedShtrat = undefined;
    }

    openForm = (shtrat_id?: string) => {
        shtrat_id? this.selectShtrat(shtrat_id) : this.cancelSelectedShtrat();
        this.editMode = true;
    }

    closeForm = () => {
        this.editMode = false;
    }

    createShtrat = async (Shtrat: IShtrat) => {
        this.loading = true;
        Shtrat.shtrat_id = uuid();
        try{
            await agent.Shtreter.create(Shtrat);
            runInAction(() => {
                this.Shtreter.push(Shtrat);
                this.selectedShtrat = Shtrat;
                this.editMode = false;
                this.loading = false;
            })
        } catch(error){
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    updateShtrat = async (Shtrat: IShtrat) => {
        this.loading = true;
        try{
            await agent.Shtreter.update(Shtrat);
            runInAction(() => {
                this.Shtreter = [...this.Shtreter.filter(sh => sh.shtrat_id !== Shtrat.shtrat_id), Shtrat];
                this.selectedShtrat = Shtrat;
                this.editMode = false;
                this.loading = false;
            })
        } catch (error){
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    deleteShtrat = async (shtrat_id: string) => {
        this.loading = true;
        try{
            await agent.Shtreter.delete(shtrat_id);
            runInAction(() => {
                this.Shtreter = [...this.Shtreter.filter(sh => sh.shtrat_id !== shtrat_id)];
                if (this.selectedShtrat?.shtrat_id === shtrat_id) this.cancelSelectedShtrat();
                this.loading = false;
            })
        } catch(error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    llojiShtreterve: ILlojiShtratit[] =[];

    getLlojiShtreterve = async() => {
        try{
            const llojiShtreterve = await agent.llojiShtreterve.list();
            llojiShtreterve.forEach(llojiShtratit => {
                    this.llojiShtreterve.push(llojiShtratit);
                })
                return llojiShtreterve;
        } catch(error){
            console.log(error);
        }
    }
}