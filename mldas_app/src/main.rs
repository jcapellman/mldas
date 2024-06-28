#[macro_use]
extern crate windows_service;

use std::ffi::OsString;
use windows_service::{Result, service_dispatcher};

define_windows_service!(ffi_service_main, my_service_main);

fn my_service_main(arguments: Vec<OsString>) {
}

fn main() -> Result<()> {
    service_dispatcher::start("mldas", ffi_service_main)?;
    Ok(())
}