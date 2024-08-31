import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Stack from '@mui/material/Stack';
import Typography from '@mui/material/Typography';


const TopNavbar = () => {
    return (
        <Stack spacing={2} direction="row" sx={{position:'fixed', left:0, right:0, zIndex:2}}>
            <AppBar position="static">
                <Typography variant='h6' noWrap component="div" sx={{flexGrow:1, padding:'10px'}}>
                    Catat Uang
                </Typography>
            </AppBar>
        </Stack>
    )
}

export default TopNavbar;