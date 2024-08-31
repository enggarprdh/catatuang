import * as React from 'react';
import Paper  from '@mui/material/Paper';
import BottomNavbar from '../components/bottom-navbar';



const Bottom = () => {
    return (
        <Paper sx={{position:'fixed', bottom: 0 , left:0, right:0,}} elevation={3}>
                <BottomNavbar/>
        </Paper>
    )
}


export default Bottom;