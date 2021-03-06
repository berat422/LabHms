import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import {v4 as uuid} from 'uuid';
import { IDhoma } from "../models/IDhoma";

export default class DhomaStore {
    // Dhomat: IDhoma[] = [];
    selectedDhoma: IDhoma | undefined = undefined;
    editMode = false;
    detailsmode=false;
    loading = false;
    loadingInitial = false;
    dhomaRegistry = new Map<string, IDhoma>();

    constructor(){
        makeAutoObservable(this)
    }

    loadDhomat = async () => {
        this.setLoadingInitial(true);
        // this.Dhomat = [];
        try{
            const Dhomat = await agent.Dhomat.list();
                Dhomat.forEach(Dhoma => {
                    // this.Dhomat.push(Dhoma);
                    this.dhomaRegistry.set(Dhoma.dhoma_Id, Dhoma);
                })
                this.setLoadingInitial(false);
        } catch(error){
            console.log(error);
                this.setLoadingInitial(true);
        }
    }

    get Dhomat(){
        return Array.from(this.dhomaRegistry.values());
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    selectDhoma = async(dhoma_id: string) => {
        // this.selectedDhoma = await agent.Dhomat.details(dhoma_id);
            this.selectedDhoma = this.dhomaRegistry.get(dhoma_id);
    }


    cancelSelectedDhoma = () => {
        this.selectedDhoma = undefined;
    }

    openForm = (dhoma_id?: string) => {
        dhoma_id? this.selectDhoma(dhoma_id) : this.cancelSelectedDhoma();
        this.editMode = true;
    }

    closeForm = () => {
        this.editMode = false;
    }

    openDetails=(id:string)=>{
        this.selectDhoma(id);
        this.detailsmode=true;
    }

    closeDetails=()=>{
        this.detailsmode=false;
    }

    createDhoma = async (Dhoma: IDhoma) => {
        this.loading = true;
        Dhoma.dhoma_Id = uuid();
        try{
            await agent.Dhomat.create(Dhoma);
            runInAction(() => {
                // this.Dhomat.push(Dhoma);
                this.dhomaRegistry.set(Dhoma.dhoma_Id, Dhoma);
                this.selectedDhoma = Dhoma;
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

    updateDhoma = async (Dhoma: IDhoma) => {
        this.loading = true;
        try{
            await agent.Dhomat.update(Dhoma);
            runInAction(() => {
                // this.Dhomat = [...this.Dhomat.filter(dh => dh.dhoma_Id !== Dhoma.dhoma_Id), Dhoma];
                this.dhomaRegistry.set(Dhoma.dhoma_Id, Dhoma);
                this.selectedDhoma = Dhoma;
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

    deleteDhoma = async (dhoma_id: string) => {
        this.loading = true;
        try{
            await agent.Dhomat.delete(dhoma_id);
            runInAction(() => {
                // this.Dhomat = [...this.Dhomat.filter(dh => dh.dhoma_Id !== dhoma_id)];
                this.dhomaRegistry.delete(dhoma_id);
                if (this.selectedDhoma?.dhoma_Id === dhoma_id) this.cancelSelectedDhoma();
                this.loading = false;
            })
        } catch(error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }
}