import { Dialog, DialogContent, DialogTitle, makeStyles, withStyles } from '@material-ui/core';
import React from 'react'
import { Button, Input, ItemGroup } from 'semantic-ui-react';
import { useStoreAmbulancat, useStoreBarnat, useStoreDepartment, useStoreDhoma, useStoreDoktorat, useStoreFaturat, useStoreLaboratori, useStorePacientat, useStorePaisjet, useStoreTerminet } from '../../app/stores/store';
import CloseIcon from '@material-ui/icons/Close';
import LaboratoriStore from '../../app/store/LaboratoriStore';

const useStyles=makeStyles(theme=>({
    dialogWrapper: {
        padding:theme.spacing(2),
        position:"absolute",
        top:theme.spacing(5)
    }

    
}))
export default function PopUp(props:any) {
const {title,children,openPopup,setopenPopup}=props;
const {PacientatStore}=useStorePacientat();
const{selectedPacienti,closeDetails,closeForm}=PacientatStore
const {PaisjetStore}=useStorePaisjet();
const{paisjet,openForm,selectPaisja,deletePaisja,selectedPaisja,editmode}=PaisjetStore;
const {BarnatStore}=useStoreBarnat();
const{}=BarnatStore;
const {DoktoratStore}=useStoreDoktorat();
    const{}=DoktoratStore;
    const {TerminetStore}=useStoreTerminet();
    const{}=TerminetStore;
    const {FaturatStore}=useStoreFaturat();
    const {DepartmentStore}=useStoreDepartment();
    const {DhomaStore} = useStoreDhoma();
    const {LaboratoriStore} = useStoreLaboratori();
    const {AmbulancaStore} = useStoreAmbulancat();
    const{selectedFatura, Faturat, selectFatura,deleteFatura,editMode}=FaturatStore;
   
 const classes=useStyles()

 function close(){
     closeDetails();
    closeForm();
    PaisjetStore.closeForm();
    PaisjetStore.closeDetails();
    BarnatStore.closeForm();
    TerminetStore.closeForm();
    TerminetStore.closeDetails();
    BarnatStore.closeDetails();
    DoktoratStore.closeForm();
    DoktoratStore.closeDetails();
    FaturatStore.closeForm();
    FaturatStore.closeDetails();
    DepartmentStore.closeForm();
    DhomaStore.closeForm();
    LaboratoriStore.closeForm();
    AmbulancaStore.closeForm();
   
    
 }
    return (
        <Dialog open={openPopup}
        
        fullWidth>
            
            <DialogTitle>
                <ItemGroup>
             <div >{title}</div>
             <Button  onClick={()=>close()}floated="right" content={<CloseIcon/>} color="red"/>
             </ItemGroup>
            </DialogTitle>
            <DialogContent>
                {children}
            </DialogContent>

        </Dialog>


    )
}
