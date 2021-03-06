import { Dialog, DialogContent, DialogTitle, makeStyles, withStyles } from '@material-ui/core';
import React from 'react'
import { Button, Input, ItemGroup } from 'semantic-ui-react';
import { StoreLlojiShtratit, useStoreBarnat, useStoreDepartment, useStoreDhoma, useStoreDoktorat, useStoreFaturat, useStoreLaboratori, useStoreLlojiShtratit, useStorePacientat, useStorePaisjet, useStoreShtrat, useStoreTerminet } from '../../app/stores/store';
import CloseIcon from '@material-ui/icons/Close';
import LaboratoriStore from '../../app/store/LaboratoriStore';
import shtratStore from '../../app/stores/shtratStore';

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
const{}=shtratStore;
const {ShtratStore} = useStoreShtrat();
const{}=StoreLlojiShtratit;
const {LlojiShtratitStore} = useStoreLlojiShtratit();
   
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
    DhomaStore.closeDetails();
    LaboratoriStore.closeForm();
    ShtratStore.closeForm();
    ShtratStore.closeForm();
    LlojiShtratitStore.closeForm();
    LlojiShtratitStore.closeDetails();
    DepartmentStore.closeDetails();
    DepartmentStore.closeForm();
    
    
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
